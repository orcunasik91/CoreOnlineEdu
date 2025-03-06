using CoreOnlineEdu.WebUI.Dtos.AboutDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("[area]/[controller]/[action]/{id?}")]
public class AboutController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
        return View(result);
    }

    public async Task<IActionResult> RemoveAbout(int id)
    {
        await client.DeleteAsync($"abouts/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> CreateAbout()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
    {
        await client.PostAsJsonAsync("abouts", createAboutDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateAbout(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateAboutDto>($"abouts/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        await client.PutAsJsonAsync("abouts", updateAboutDto);
        return RedirectToAction(nameof(Index));
    }
}