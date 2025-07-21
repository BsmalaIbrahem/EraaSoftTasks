using DataLayer.Data;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using Stripe.Checkout;
using Stripe.Climate;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Authorize]
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly IRepository<Cart> _repository;
        private readonly IRepository<Event> _eventRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public CartController(IRepository<Cart> repository, UserManager<ApplicationUser> userManager, IRepository<Event> eventRepository, ApplicationDbContext context)
        {
            _repository = repository;
            _userManager = userManager;
            _eventRepository = eventRepository;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) 
            {
                return NotFound();
            }
            var data = await _repository.GetAllAsync(x => x.UserId == user.Id, includeChain: x => x.Include(q => q.Event));
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCartVM request)
        {
            var user = await GetUser();
            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            var existingCartItem = await _repository.GetOneAsync(x => x.UserId == user.Id && x.EventId == request.EventId);
            if (existingCartItem != null)
            {
                if (!await IsValidCount(request.Count + existingCartItem.Count, request.EventId))
                {
                    TempData["Error"] = "Invalid count or not enough tickets available.";
                    return Json(new { success = false, message = "Invalid count or not enough tickets available." });
                }
                existingCartItem.Count += request.Count;
                await _repository.UpdateAsync(existingCartItem);
            }
            else
            {
                if (!await IsValidCount(request.Count, request.EventId))
                {
                    TempData["Error"] = "Invalid count or not enough tickets available.";
                    return Json(new { success = false, message = "Invalid count or not enough tickets available." });
                }
                await _repository.AddAsync(new Cart
                {
                    UserId = user.Id,
                    EventId = request.EventId,
                    Count = request.Count,
                });
            }
            TempData["Success"] = "Event Added To cart successfully.";
            return Json(new { success = true, message = "Event added to cart.", data = request });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int EventId)
        {
            var user = await GetUser();
            if (EventId <= 0)
            {
                return BadRequest("Invalid event ID.");
            }
            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            var cartItem = await _repository.GetOneAsync(x => x.UserId == user.Id && x.EventId == EventId);
            if (cartItem == null)
            {
                return NotFound("Cart item not found.");
            }
            await _repository.DeleteAsync(x => x.UserId == user.Id && x.EventId == EventId);
            TempData["Success"] = "Event removed from cart successfully.";
            return Json(new { success = true, message = "Event removed from cart." });

        }

        [HttpPost]
        public async Task<IActionResult> IncrementEventCartCount(AddCartVM request)
        {
            var user = await GetUser();
            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            var existingCartItem = await _repository.GetOneAsync(x => x.UserId == user.Id && x.EventId == request.EventId);
            if (existingCartItem == null)
            {
                return NotFound("Cart item not found.");
            }
            else
            {
                if (!await IsValidCount(request.Count + existingCartItem.Count, request.EventId))
                {
                    TempData["Error"] = "Invalid count or not enough tickets available.";
                    return Json(new { success = false, message = "Invalid count or not enough tickets available." });
                }
                existingCartItem.Count += request.Count;
                await _repository.UpdateAsync(existingCartItem);
            }
            
            return Json(new { success = true, message = "Event Count Incremented in cart." });
        }

        [HttpPost]
        public async Task<IActionResult> DecrementEventCartCount(AddCartVM request)
        {
            var user = await GetUser();
            if (user == null)
            {
                return Unauthorized("User not found.");
            }
            var existingCartItem = await _repository.GetOneAsync(x => x.UserId == user.Id && x.EventId == request.EventId);
            if (existingCartItem == null)
            {
                return NotFound("Cart item not found.");
            }
            else
            {
                if (existingCartItem.Count <= 1)
                {
                    return BadRequest("Count cannot be less than 1.");
                }
                existingCartItem.Count -= request.Count;
                await _repository.UpdateAsync(existingCartItem);
            }
            
            return Json(new { success = true, message = "Event Count Decremented in cart." });
        }

        public async Task<IActionResult> Pay()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            var data = await _repository.GetAllAsync(x => x.UserId == user.Id, includeChain: x => x.Include(q => q.Event));
            if (data == null || data.Count() == 0)
            {
                return NotFound();
            }
            var order = new DataLayer.Models.Order();

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                     order = new DataLayer.Models.Order
                    {
                        UserId = user.Id,
                        TotalPrice = data.Sum(x => x.Event.Price * x.Count),
                        Status = OrderStstus.Pending,
                    };
                    await _context.Orders.AddAsync(order);
                    await _context.SaveChangesAsync();

                    foreach (var item in data)
                    {
                        if(! await IsValidCount(item.Count, item.EventId))
                        {
                            throw new Exception($"Invalid count or not enough {item.Event.Title} tickets available.");
                        }
                        else
                        {
                            var EventOrder = new EventOrder
                            {
                                OrderId = order.Id,
                                EventId = item.EventId,
                                Count = item.Count,
                                Price = item.Event.Price * item.Count
                            };

                            await _context.EventOrders.AddAsync(EventOrder);
                            await _context.SaveChangesAsync();
                        }
                    }
                    await transaction.CommitAsync();
                }
                catch(Exception ex)
                {
                    await transaction.RollbackAsync();
                    TempData["Error"] = ex.Message;
                    return RedirectToAction(nameof(Index));
                }
            }


            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                SuccessUrl = $"{Request.Scheme}://{Request.Host}/Customer/Checkout/Success?orderId={order.Id}",
                CancelUrl = $"{Request.Scheme}://{Request.Host}/Customer/Checkout/Cancel",
            };

            foreach(var item in data)
            {
                options.LineItems.Add(new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "egp",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Event.Title,
                            Description = item.Event.Description,
                        },
                        UnitAmount = (long)item.Event.Price * 100,
                    },
                    Quantity = item.Count,
                });
            }

            var service = new SessionService();
            var session = service.Create(options);
            order.SessionId = session.Id;
            await _context.SaveChangesAsync();

            return Redirect(session.Url);
        }

        private async Task<bool> IsValidCount(int count, int EventId)
        {
            var eventItem = await _eventRepository.GetOneAsync(x => x.Id == EventId);
            if (eventItem == null || eventItem.AvailableTickets < count)
            {
                return false;
            }

            return true;
        }
        private async Task<ApplicationUser?> GetUser()
        {
            return await _userManager.GetUserAsync(User);
        }

    }
}
