using DataLayer.Data;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Cart> _cartRepository;
        private readonly ApplicationDbContext _context;
        public CheckoutController(IRepository<Order> _orderRepository, IRepository<Cart> _cartRepository, ApplicationDbContext _contex)
        {
            this._orderRepository = _orderRepository;
            this._cartRepository = _cartRepository;
            this._context = _contex;
        }
        public async Task<IActionResult> Success(int orderId)
        {
            var order = await _orderRepository.GetOneAsync(x => x.Id == orderId, includeChain: x => x.Include(q => q.Events).ThenInclude(q => q.Event));
            if (order == null) 
                return NotFound();

            if (order.Status == OrderStstus.Pending)
            {

                order.Status = OrderStstus.Processing;

                var service = new SessionService();
                var session = service.Get(order.SessionId);
                order.ReferenceId = session.PaymentIntentId;

                await _orderRepository.SaveChangesAsync();

                foreach (var orderEvent in order.Events)
                {
                    orderEvent.Event.AvailableTickets = orderEvent.Event.AvailableTickets - orderEvent.Count;
                    await _context.SaveChangesAsync();
                }

                var carts = await _cartRepository.GetAllAsync(x => x.UserId == order.UserId, includeChain: x => x.Include(q => q.Event));
                foreach (var cart in carts)
                {
                    await _cartRepository.DeleteAsync(x => x.UserId == cart.UserId && x.EventId == cart.EventId);
                }

            }
            return View();
        }

    
        public async Task<IActionResult> Cancel(int orderId)
        {
            var order = await _orderRepository.GetOneAsync(x => x.Id == orderId, includeChain: x => x.Include(q => q.Events).ThenInclude(q => q.Event));
            if (order == null)
                return NotFound();

            if (order.Status == OrderStstus.Pending)
            {
                order.Status = OrderStstus.Canceled;
                await _orderRepository.SaveChangesAsync();
            }

            return View();
        }
    }
}
