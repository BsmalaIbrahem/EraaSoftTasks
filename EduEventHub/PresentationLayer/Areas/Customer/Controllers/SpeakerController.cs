using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class SpeakerController : Controller
    {
        private readonly IRepository<Speaker> _repository;
        public SpeakerController(IRepository<Speaker> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _repository.GetAllAsync(orderBy: q => q.OrderByDescending(x => x.Id));
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var speaker = await _repository.GetOneAsync(x => x.Id == id, 
                                                includeChain: q => q.Include(e => e.EventContents)
                                                               .ThenInclude(ec => ec.EventAgenda)
                                                               .ThenInclude(a => a.Event)
                                                               .Include(q => q.SocialMedias)
                                            );
            if (speaker == null)
            {
                return NotFound();
            }

            var events = speaker.EventContents.Select(ec => ec.EventAgenda.Event).Distinct().ToList();

            var data = new SpeakerDetailsViewModel
            {
                Speaker = speaker,
                Events = events
            };

            return View(data);
        }
    }
}
