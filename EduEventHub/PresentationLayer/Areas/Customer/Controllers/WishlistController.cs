using DataLayer.Data;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Authorize]
    public class WishlistController : Controller
    {
        private readonly IRepository<Wishlist> _repository;
        private readonly UserManager<ApplicationUser> _userManager;
        public WishlistController(IRepository<Wishlist> repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized("User not found.");
            }
            var data = await _repository.GetAllAsync(filter: x=>x.UserId ==  user.Id, includeChain : q => q.Include(x => x.Event));
            return View(data);
        }

        public async Task<IActionResult> Add(int EventId)
        {
            if (EventId <= 0)
            {
                return BadRequest("Invalid event ID.");
            }

            var user = await _userManager.GetUserAsync(User);

            if(user == null)
            {
                return Unauthorized("User not found.");
            }

            await _repository.AddAsync( new Wishlist
                {
                    UserId = user.Id,
                    EventId = EventId
                });

            TempData["Success"] = "Event added to wishlist successfully.";
            return Json(new { success = true, message = "Event added to wishlist." });
        }

        public async Task<IActionResult> Delete(int EventId)
        {
            if(EventId <= 0)
            {
                return BadRequest("Invalid event ID.");
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            var wishlist = await _repository.GetOneAsync(x => x.UserId == user.Id && x.EventId == EventId);
            if (wishlist == null)
            {
                return NotFound("Wishlist item not found.");
            }

            await _repository.DeleteAsync(x => x.UserId == user.Id && x.EventId == EventId);
            TempData["Success"] = "Event Deleted from wishlist successfully.";

            return Json(new { success = true, message = "Event Removed to wishlist.." });
        }
    }
}
