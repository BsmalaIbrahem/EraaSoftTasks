using DataLayer.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Text.Json;

namespace PresentationLayer.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        public IActionResult New(int DoctorId)
        {
            var doctor = _context.Doctors.Include(x => x.DoctorSchedules).FirstOrDefault(x => x.Id == DoctorId);
            if(doctor == null)
            {
                return NotFound();
            }

            var doctorDays = doctor.DoctorSchedules.Select(x => (int)x.DayName).ToArray();
            ViewBag.doctorDays = JsonSerializer.Serialize(doctorDays);
            return View(doctor);
        }

        public IActionResult GetAvailableTime(AvailableTimeVM request)
        {
            var day = request.Date.DayOfWeek.ToString();

            var doctor = _context.Doctors.FirstOrDefault(x => x.Id == request.DoctorId);
            if(doctor == null)
            {
                return NotFound("Doctor not found");
            }

            var doctorSchedule = _context.DoctorSchedules.Where(x => x.DoctorId == request.DoctorId && x.DayName.Equals(day)).FirstOrDefault();
            //

            return Json(day);
        }

        [HttpPost]
        public IActionResult New()
        {
            //
            return View();
        }
    }
}
