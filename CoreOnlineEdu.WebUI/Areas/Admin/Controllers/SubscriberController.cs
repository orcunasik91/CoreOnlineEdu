using CoreOnlineEdu.WebUI.Dtos.SubscriberDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class SubscriberController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultSubscriberDto>>("Subscribers");
        return View(result);
    }

    public async Task<IActionResult> RemoveSubscriber(int id)
    {
        await client.DeleteAsync($"Subscribers/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult CreateSubscriber()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscriber(CreateSubscriberDto createSubscriberDto)
    {
        await client.PostAsJsonAsync("Subscribers", createSubscriberDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateSubscriber(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateSubscriberDto>($"Subscribers/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateSubscriber(UpdateSubscriberDto updateSubscriberDto)
    {
        await client.PutAsJsonAsync("Subscribers", updateSubscriberDto);
        return RedirectToAction(nameof(Index));
    }
}