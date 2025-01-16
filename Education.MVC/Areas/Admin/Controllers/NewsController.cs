using Microsoft.AspNetCore.Mvc;

namespace Education.MVC.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
