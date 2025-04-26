using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
