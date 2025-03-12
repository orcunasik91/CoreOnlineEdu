using CoreOnlineEdu.WebUI.Dtos.ContactDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class ContactController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultContactDto>>("contacts");
        return View(result);
    }
    public async Task<IActionResult> RemoveContact(int id)
    {
        await client.DeleteAsync($"contacts/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult CreateContact()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
    {
        await client.PostAsJsonAsync("contacts", createContactDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateContact(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateContactDto>($"contacts/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
    {
        await client.PutAsJsonAsync("contacts", updateContactDto);
        return RedirectToAction(nameof(Index));
    }
}