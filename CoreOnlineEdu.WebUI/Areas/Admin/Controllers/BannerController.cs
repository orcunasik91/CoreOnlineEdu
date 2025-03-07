using CoreOnlineEdu.WebUI.Dtos.BannerDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class BannerController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
        return View(result);
    }

    public async Task<IActionResult> RemoveBanner(int id)
    {
        await client.DeleteAsync($"banners/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> CreateBanner()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
    {
        await client.PostAsJsonAsync("banners", createBannerDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateBanner(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateBannerDto>($"banners/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
    {
        await client.PutAsJsonAsync("banners", updateBannerDto);
        return RedirectToAction(nameof(Index));
    }
}