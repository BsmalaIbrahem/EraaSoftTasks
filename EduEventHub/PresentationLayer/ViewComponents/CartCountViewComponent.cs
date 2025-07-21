using DataLayer.Data;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PresentationLayer.ViewComponents
{
    public class CartCountViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRepository<Cart> _cartRepository;
        public CartCountViewComponent(UserManager<ApplicationUser> _userManager, IRepository<Cart> _cartRepository)
        {
            this._userManager = _userManager;
            this._cartRepository = _cartRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return View(0); 
            }
            var cartCount = await _cartRepository.CountAsync(x => x.UserId == user.Id);
            return View(cartCount);
        }
    }
}
