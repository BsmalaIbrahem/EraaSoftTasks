using DataLayer.Data;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Helpers;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpeakerController : Controller
    {
        private readonly IRepository<Speaker> _repository;
        
        public SpeakerController(IRepository<Speaker> speakerRepository)
        {
            _repository = speakerRepository;
        }

        public async Task<IActionResult> Index(PageFiltesVM filter)
        {
            var items = await _repository.GetAllAsync(skip: filter.SkipNumber, take:filter.PageSize);
            var count = await _repository.CountAsync();
            var data = new ModelsWithPaginationVM<Speaker>()
            {
                Items = items.ToList(),
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 0,
                    PageSize = filter.PageSize ?? 0,
                    TotalCount = count
                }
            };
            return View(data);
        }

        public IActionResult Create()
        {
            return View(new Speaker());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Speaker speaker, IFormFile ImgPath)
        {
            if(!ModelState.IsValid)
            {
                return View(speaker);
            }

            if (ImgPath != null && ImgPath.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\speakers";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                speaker.ImgPath = path+'\\'+fileName;
            }
            else
            {
                ModelState.AddModelError("ImgPath", "Image is required.");
                return View(speaker);
            }

            await _repository.AddAsync(speaker);

            TempData["SuccessMessage"] = "Speaker created successfully.";

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var data = await _repository.GetOneAsync(x => x.Id == id, includeChain: e => e.Include(q => q.EventContents)
                                                                                          .ThenInclude(q => q.EventAgenda)
                                                                                          .ThenInclude(q => q.Event)
                                                                                    );
            if (data == null)
                return NotFound();

            var events = data.EventContents.Select(x => x.EventAgenda.Event).Distinct().ToList();
            ViewBag.Events = events;
            return View(data) ;
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Speaker speaker, IFormFile ImgPath)
        {
            ModelState.Remove("ImgPath");
            if (!ModelState.IsValid)
            {
                return View(speaker);
            }

            var oldData = await _repository.GetOneAsync(x => x.Id  == speaker.Id, AsNoTracking:true);
            if (oldData == null)
            {
                return NotFound();
            }

            if (ImgPath != null && ImgPath.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\speakers";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\"+path);
                await FileHelper.UploadFile(filePath, ImgPath);
                speaker.ImgPath = path + '\\' + fileName;
            }
            else
            {
                speaker.ImgPath = oldData.ImgPath;
            }

            await _repository.UpdateAsync(speaker);
            TempData["SuccessMessage"] = "Speaker Updated successfully.";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await _repository.GetOneAsync(x => x.Id == id);
            if (data == null)
                return NotFound();
            await _repository.DeleteAsync(x => x.Id == id);
            TempData["SuccessMessage"] = "Speaker Deleted successfully.";
            return RedirectToAction(nameof(Index));
        }

    }
}
