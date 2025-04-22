using CoreOnlineEdu.WebUI.Dtos.TestimonialDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class TestimonialController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultTestimonialDto>>("Testimonials");
        return View(result);
    }

    public async Task<IActionResult> RemoveTestimonial(int id)
    {
        await client.DeleteAsync($"Testimonials/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult CreateTestimonial()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
    {
        await client.PostAsJsonAsync("Testimonials", createTestimonialDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateTestimonial(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateTestimonialDto>($"Testimonials/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
    {
        await client.PutAsJsonAsync("Testimonials", updateTestimonialDto);
        return RedirectToAction(nameof(Index));
    }
}