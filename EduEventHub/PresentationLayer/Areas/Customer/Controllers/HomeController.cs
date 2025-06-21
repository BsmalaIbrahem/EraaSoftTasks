using DataLayer.Data;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IRepository<Event> _eventRepository;
        private readonly IRepository<Speaker> _speakerRepository;
        public HomeController(IRepository<Event> eventRepository, IRepository<Speaker> speakerRepository)
        {
            _eventRepository = eventRepository;
            _speakerRepository = speakerRepository;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _eventRepository.GetAllAsync(orderBy: e => e.OrderByDescending(ev => ev.StartDate), skip:0, take:3);
            var speakers = await _speakerRepository.GetAllAsync(orderBy: e => e.OrderByDescending(ev => ev.Id), skip:0, take:8, includeChain: x =>x.Include(q => q.SocialMedias));

            var result = new CustomerHomeVM()
            {
                Events = events,
                Speakers = speakers
            };
            return View(result);
        }
    }
}
