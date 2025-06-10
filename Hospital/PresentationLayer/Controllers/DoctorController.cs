using DataLayer.DataAccess;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;

namespace PresentationLayer.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        public IActionResult Index(DoctorFiltersVM request)
        {
            IQueryable<Doctor> doctors = _context.Doctors;
            
            if (!string.IsNullOrEmpty(request.DoctorName))
            {
                doctors = doctors.Where(x => x.Name.Contains(request.DoctorName));
            }
            if (request.SpecializationId != null && request.SpecializationId != 0)
            {
                doctors = doctors.Where(x => x.SpecializationId == request.SpecializationId);
            }

            var TotalCount= doctors.Count();
            var TotalPages = (int) Math.Ceiling((double)TotalCount / request.PageSize);

            ViewBag.CurrentPage = request.Page;
            ViewBag.TotalCount = TotalCount;
            ViewBag.TotalPages = TotalPages;
            ViewBag.DoctorName = request.DoctorName;
            ViewBag.PageSize = request.PageSize;

            var Specializations = _context.Specializations.ToList();
            ViewBag.Specializations = Specializations;
            ViewBag.SpecializationId = request.SpecializationId;

            doctors = doctors.Skip((request.Page - 1) * request.PageSize).Take(request.PageSize).Include(x => x.specialization);
            return View(doctors.ToList());
        }

        

       
    }
}
