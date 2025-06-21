using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IRepository<Category> _repository;

        public CategoryController(IRepository<Category> Repository)
        {
            _repository = Repository;
        }

        public IActionResult Index()
        {
            return View();
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
