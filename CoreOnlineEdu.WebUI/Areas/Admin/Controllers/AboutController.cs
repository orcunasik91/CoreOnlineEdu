using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}