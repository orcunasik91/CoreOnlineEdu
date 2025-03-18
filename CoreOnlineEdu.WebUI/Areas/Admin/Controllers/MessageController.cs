using CoreOnlineEdu.WebUI.Dtos.MessageDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class MessageController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultMessageDto>>("Messages");
        return View(result);
    }

    public async Task<IActionResult> RemoveMessage(int id)
    {
        await client.DeleteAsync($"Messages/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> MessageDetail(int id)
    {
        var result = await client.GetFromJsonAsync<GetMessageByIdDto>($"Messages/{id}");
        return View(result);
    }
}