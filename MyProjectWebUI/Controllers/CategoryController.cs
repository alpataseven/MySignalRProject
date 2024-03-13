using Microsoft.AspNetCore.Mvc;

namespace MyProjectWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
