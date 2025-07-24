using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = ("SuperAdmin"))]
    public class OrderController : Controller
    {
        private readonly IRepository<Order> _repository;
        public OrderController(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index(FilterOrderVM filter)
        {
            Expression<Func<Order, bool>>? expression = null;
            if(filter.OrderStstus != null)
            {
                expression = x => x.Status == filter.OrderStstus;
            }
            var orders = await _repository.GetAllAsync(includeChain: x => x.Include(q => q.User), filter: expression, skip: filter.PageFilter.SkipNumber, take: filter.PageFilter.PageSize);
            
            var data = new ModelsWithPaginationVM<Order>()
            {
                Items = orders,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageFilter.PageNumber ?? 0,
                    PageSize = filter.PageFilter.PageSize ?? 0,
                    TotalCount = await _repository.CountAsync(expression)
                }
            };
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await _repository.GetOneAsync(x => x.Id == id, includeChain: x => x.Include(q => q.User).Include(q => q.Events).ThenInclude(q => q.Event));
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeOrderStatus(ChangeOrderStatusVM request)
        {
            var order = await _repository.GetOneAsync(x => x.Id == request.OrderId);
            if (order == null)
            {
                return NotFound();
            }
            order.Status = request.OrderStatus;
            await _repository.SaveChangesAsync();

            return Json(new { message = "success" });
        }
    }
}
