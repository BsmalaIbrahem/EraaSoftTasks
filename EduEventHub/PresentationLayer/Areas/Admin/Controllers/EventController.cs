using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Helpers;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly IRepository<Event> _repository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Speaker> _speakerRepository;

        public EventController(IRepository<Event> Repository, IRepository<Category> CategoryRepository, IRepository<Speaker> SpeakerRepository)
        {
            _repository = Repository;
            _categoryRepository = CategoryRepository;
            _speakerRepository = SpeakerRepository;
        }
        public async Task<IActionResult> Index(PageFiltesVM filter)
        {
            var data = await _repository.GetAllAsync(skip: filter.PageNumber - 1, take: filter.PageSize);
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            await SetViewBagData();

            return View(new CreateEventVM());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEventVM model, IFormFile ImgPath)
        {
            if (!ModelState.IsValid)
            {
                await SetViewBagData();

                return View(model);
            }

            if (ImgPath != null && ImgPath.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\news";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                model.ImgPath = path + '\\' + fileName;
            }
            else
            {
                ModelState.AddModelError("ImgPath", "Image is required.");
                await SetViewBagData();
                return View(model);
            }

            var eventEntry = new Event()
            {
                Title = model.Title,
                Description = model.Description,
                CategoryId = model.CategoryId,
                ImgPath = model.ImgPath,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Price = model.Price,
                Agenda= model.Agendas.Select(a => new EventAgenda
                {
                    Date = a.Date,
                    EventAgendaContents = a.Contents.Select(c => new EventContent
                    {
                        SpeakerId = c.SpeakerId,
                        Subject = c.Subject,
                        StartTime = c.StartTime,

                    }).ToList()
                }).ToList()
            };
            await _repository.AddAsync(eventEntry);

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(int id)
        {
            //   
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(x => x.Id == id);
            return RedirectToAction(nameof(Index));
        }

        private async Task SetViewBagData(int selectedCategoyId = 1, int selectedSpeaker = 1)
        {
            var categories = await _categoryRepository.GetAllAsync();
            var speakers = await _speakerRepository.GetAllAsync();

            ViewBag.Categories = new SelectList(categories, "Id", "Name", selectedCategoyId);
            ViewBag.Speakers = new SelectList(speakers, "Id", "Name", selectedSpeaker);
        }
    }
}
