using Microsoft.AspNetCore.Mvc;

namespace Education.MVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
