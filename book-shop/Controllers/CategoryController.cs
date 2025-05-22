using Microsoft.AspNetCore.Mvc;

namespace book_shop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
