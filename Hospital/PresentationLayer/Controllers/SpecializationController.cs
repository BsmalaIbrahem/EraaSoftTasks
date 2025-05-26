using DataLayer.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PresentationLayer.Controllers
{
    public class SpecializationController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        public IActionResult Index(string slug)
        {
            var specialization = _context.Specializations.Where(x => x.Slug == slug).Include(x => x.Doctors).FirstOrDefault();
            return View(specialization);
        }
    }
}
