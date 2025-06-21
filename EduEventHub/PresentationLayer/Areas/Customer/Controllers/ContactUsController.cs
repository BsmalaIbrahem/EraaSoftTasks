using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
