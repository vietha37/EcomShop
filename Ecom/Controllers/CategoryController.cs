using Microsoft.AspNetCore.Mvc;

namespace Ecom.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
