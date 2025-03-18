using CoreOnlineEdu.WebUI.Dtos.SocialMediaDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class SocialMediaController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultSocialMediaDto>>("SocialMedias");
        return View(result);
    }

    public async Task<IActionResult> RemoveSocialMedia(int id)
    {
        await client.DeleteAsync($"SocialMedias/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult CreateSocialMedia()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
    {
        await client.PostAsJsonAsync("SocialMedias", createSocialMediaDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateSocialMedia(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateSocialMediaDto>($"SocialMedias/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
    {
        await client.PutAsJsonAsync("SocialMedias", updateSocialMediaDto);
        return RedirectToAction(nameof(Index));
    }
}