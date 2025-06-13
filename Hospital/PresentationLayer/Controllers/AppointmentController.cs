using DataLayer.DataAccess;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Globalization;
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

        [HttpPost]

        public IActionResult GetAvailableTime([FromBody] AvailableTimeVM request)
        {
            var day = Enum.Parse < DaysName >(request.Date.DayOfWeek.ToString());

            var doctor = _context.Doctors.Find(request.DoctorId);
            if(doctor == null)
            {
                return NotFound("Doctor not found");
            }

            var doctorSchedule = _context.DoctorSchedules.Where(x => x.DoctorId == request.DoctorId && x.DayName.Equals(day)).Select(x => new
            {
                x.StartTime,
                x.EndTime,
                x.DayName
            }).FirstOrDefault();

            var BookedSchedules = _context.Appointments.Where(x => x.Date == request.Date).Select(x => new {x.StartTime, x.EndTime}).ToList();

            return Json(new { doctorSchedule , BookedSchedules });
        }

        [HttpPost]
        public IActionResult New(BookAppoinmentVM request)
        {
            var StartTime = ConvertEasternArabicNumeralsToWestern(request.Time);
            TimeOnly time = TimeOnly.ParseExact(StartTime, "HH:mm", CultureInfo.InvariantCulture);

            _context.Appointments.Add(new Appointment
            {
                Date = request.Date,
                StartTime = time,
                EndTime = time.AddMinutes(request.ExaminationDuration),
                PatientName = request.Name,
                PatientEmail = request.Email,
                PatientPhone = request.Phone,
                DoctorId = request.DoctorId,
                Details = request.Details
            });
            _context.SaveChanges();

            TempData["Success"] = "Appointment booked successfully!";
            return RedirectToAction("Index", "Doctor");
        }

        public static string ConvertEasternArabicNumeralsToWestern(string input)
        {
            string[] arabicDigits = { "٠", "١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩" };
            for (int i = 0; i < arabicDigits.Length; i++)
            {
                input = input.Replace(arabicDigits[i], i.ToString());
            }
            return input;
        }
    }
}
