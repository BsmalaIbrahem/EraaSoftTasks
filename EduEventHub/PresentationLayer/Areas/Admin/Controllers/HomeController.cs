using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = ("SuperAdmin"))]
    public class HomeController : Controller
    {
        private readonly IRepository<Event> _eventRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Speaker> _speakerRepository;

        public HomeController(IRepository<Event> EventRepository, IRepository<Category> CategoryRepository, IRepository<Speaker> SpeakerRepository)
        {
            _eventRepository = EventRepository;
            _categoryRepository = CategoryRepository;
            _speakerRepository = SpeakerRepository;
        }
        public async Task<IActionResult> Index()
        {
            var eventsCount = (await _eventRepository.GetAllAsync()).Count();
            var speakerCount = (await _speakerRepository.GetAllAsync()).Count();
            var categoryCount = (await _categoryRepository.GetAllAsync()).Count();

            var data = new HomeVM
            {
                EventsCount = eventsCount,
                SpeakersCount = speakerCount,
                CategoriesCount = categoryCount
            };

            return View(data);
        }
    }
}
