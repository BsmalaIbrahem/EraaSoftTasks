using DataLayer.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.ViewModels;
using System.Linq;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = ("SuperAdmin"))]
    public class UserController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index(PageFiltesVM filter)
        {
            var users = _userManager.Users.Skip(filter.SkipNumber ?? 0).Take(filter.PageSize ?? 10);
            var data = new ModelsWithPaginationVM<ApplicationUser>()
            {
                Items = users.ToList(),
                Pagination = new PaginationVM
                {
                    PageNumber = 0,
                    PageSize = 10,
                    TotalCount = _userManager.Users.Count()
                }
            };
            return View(data);
        }
    }
}
