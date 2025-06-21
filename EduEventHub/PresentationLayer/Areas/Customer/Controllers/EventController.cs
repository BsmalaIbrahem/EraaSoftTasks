using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class EventController : Controller
    {
        private readonly IRepository<Event> _eventRepository;
        public EventController(IRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task<IActionResult> Index(EventFilter? filter = null)
        {
            var data = await _eventRepository.GetAllAsync(
                orderBy: q => q.OrderByDescending(e => e.StartDate)
                );
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await _eventRepository.GetOneAsync(
                                            e => e.Id == id,
                                            includeChain: q => q
                                                 .Include(e => e.Category)
                                                 .Include(e => e.Agenda)
                                                 .ThenInclude(a => a.EventAgendaContents)
                                                 .ThenInclude(ec => ec.Speaker)
                                            );
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }
    }
}
