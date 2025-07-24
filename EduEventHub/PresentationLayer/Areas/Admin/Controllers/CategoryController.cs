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
    public class CategoryController : Controller
    {
        private readonly IRepository<Category> _repository;

        public CategoryController(IRepository<Category> Repository)
        {
            _repository = Repository;
        }

        public async Task<IActionResult> Index(PageFiltesVM filter)
        {
            var items = await _repository.GetAllAsync(skip: filter.PageNumber - 1, take: filter.PageSize);
            var count = await _repository.CountAsync();
            var data = new ModelsWithPaginationVM<Category>()
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

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            await _repository.AddAsync(category);

            TempData["SuccessMessage"] = "Category created successfully.";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await _repository.GetOneAsync(x => x.Id == id);
            if(data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            await _repository.UpdateAsync(category);
            TempData["SuccessMessage"] = "Category updated successfully.";
            return RedirectToAction("Index");
        }


    }
}
