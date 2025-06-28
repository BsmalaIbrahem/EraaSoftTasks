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
        private readonly IRepository<EventAgenda> _agendaRepository;
        private readonly IRepository<EventContent> _contentRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Speaker> _speakerRepository;

        public EventController(IRepository<Event> Repository, IRepository<Category> CategoryRepository, IRepository<Speaker> SpeakerRepository, IRepository<EventAgenda> agendaRepository, IRepository<EventContent> contentRepository)
        {
            _repository = Repository;
            _categoryRepository = CategoryRepository;
            _speakerRepository = SpeakerRepository;
            _agendaRepository = agendaRepository;
            _contentRepository = contentRepository;
        }
        public async Task<IActionResult> Index(PageFiltesVM filter)
        {
            var items = await _repository.GetAllAsync(skip: filter.SkipNumber, take: filter.PageSize);
            var count = await _repository.CountAsync();
            var data = new ModelsWithPaginationVM<Event>()
            {
                Items = items,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 0,
                    PageSize = filter.PageSize ?? 0,
                    TotalCount = count
                }
            };
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

            TempData["SuccessMessage"] = "Event created successfully.";

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(int id)
        {
            var eventEntry = await _repository.GetOneAsync(x => x.Id == id, includeChain: e => e.Include(q => q.Agenda).ThenInclude(q => q.EventAgendaContents));
            if(eventEntry == null)
            {
                return NotFound();
            }

            var data = new EditEventVM
            {
                Id = eventEntry.Id,
                Title = eventEntry.Title,
                Description = eventEntry.Description,
                CategoryId = eventEntry.CategoryId,
                ImgPath = eventEntry.ImgPath,
                StartDate = eventEntry.StartDate,
                EndDate = eventEntry.EndDate,
                Price = eventEntry.Price,
                Agendas = eventEntry.Agenda.Select(a => new EditAgendaVM
                {
                    AgendaId = a.Id,
                    Date = a.Date,
                    Contents = a.EventAgendaContents.Select(c => new EditAgendaContentVM
                    {
                        ContentId = c.Id,
                        SpeakerId = c.SpeakerId,
                        Subject = c.Subject,
                        StartTime = c.StartTime
                    }).ToList()
                }).ToList()
            };

            await SetViewBagData();

            return View(data);
        }

        

        [HttpPost]
        public async Task<IActionResult> Edit(EditEventVM request, IFormFile ImgPath)
        {
            ModelState.Remove("ImgPath");
            if (!ModelState.IsValid)
            {
                await SetViewBagData(request.CategoryId);
                return View(request);
            }

            var eventEntry = await _repository.GetOneAsync(x => x.Id == request.Id,AsNoTracking:true, includeChain: e => e.Include(q => q.Agenda).ThenInclude(q => q.EventAgendaContents));
            if (eventEntry == null)
            {
                return NotFound();
            }

            if(ImgPath != null && ImgPath.Length > 0)
            {
                var ImgName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\news";
                string filePath = FileHelper.GetFilePath(ImgName, "wwwroot\\" + path);
                request.ImgPath = path + '\\' + ImgName;
            }
            else
            {
                request.ImgPath = eventEntry.ImgPath;
            }

            var UpdatedEvent = new Event
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                CategoryId = request.CategoryId,
                ImgPath = request.ImgPath,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Price = request.Price,
            };

            await _repository.UpdateAsync(UpdatedEvent);
            await EditAgenda(request.Agendas, request.Id);

            TempData["SuccessMessage"] = "Event Updated successfully.";

            return RedirectToAction(nameof(Index));
        }

        private async Task EditAgenda(List<EditAgendaVM> requests, int eventId)
        {
            foreach(var item in requests)
            {
                var agenda = await _agendaRepository.GetOneAsync(x => x.Id == item.AgendaId, AsNoTracking: true, includeChain: e => e.Include(q => q.EventAgendaContents));
                if (agenda != null) 
                {
                    agenda.Date = item.Date;
                    await _agendaRepository.UpdateAsync(agenda);
                    await EditContent(item.Contents, agenda.Id);
                }
                else
                {
                    await _agendaRepository.AddAsync(new EventAgenda()
                    {
                        EventId = eventId,
                        Date = item.Date,
                        EventAgendaContents = item.Contents.Select(c => new EventContent
                        {
                            Subject = c.Subject,
                            SpeakerId = c.SpeakerId,
                            StartTime = c.StartTime
                        }).ToList()
                    });
                }
            }
        }

        private async Task EditContent(List<EditAgendaContentVM> requests, int agendaId)
        {
            foreach (var item in requests)
            {
                var content = await _contentRepository.GetOneAsync(x => x.Id == item.ContentId);
                if (content != null)
                {
                    content.Subject = item.Subject;
                    content.SpeakerId = item.SpeakerId;
                    content.StartTime = item.StartTime;
                    await _contentRepository.UpdateAsync(content);
                }
                else
                {
                    await _contentRepository.AddAsync(new EventContent()
                    {
                        EventAgendaId = agendaId,
                        Subject = item.Subject,
                        SpeakerId = item.SpeakerId,
                        StartTime = item.StartTime
                    });
                }
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(x => x.Id == id);
            TempData["SuccessMessage"] = "Event Deleted successfully.";
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
