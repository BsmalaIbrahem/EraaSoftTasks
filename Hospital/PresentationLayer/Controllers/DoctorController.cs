using DataLayer.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PresentationLayer.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            var doctors = _context.Doctors.Skip((page - 1) * pageSize).Take(pageSize).Include(x => x.specialization).ToList();
            return View(doctors);
        }
    }
}
