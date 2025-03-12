using CoreOnlineEdu.WebUI.Dtos.CourseCategoryDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class CourseCategoryController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("coursecategories");
        return View(result);
    }

    [HttpGet]
    public IActionResult CreateCourseCategory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCourseCategory(CreateCourseCategoryDto courseCategoryDto)
    {
        await client.PostAsJsonAsync("coursecategories", courseCategoryDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateCourseCategory(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateCourseCategoryDto>($"coursecategories/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateCourseCategory(UpdateCourseCategoryDto courseCategoryDto)
    {
        await client.PutAsJsonAsync("coursecategories", courseCategoryDto);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> RemoveCourseCategory(int id)
    {
        await client.DeleteAsync($"coursecategories/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> ShowOnHomeCourseCategory(int id)
    {
        await client.GetAsync($"coursecategories/showonhome/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> DontShowOnHomeCourseCategory(int id)
    {
        await client.GetAsync($"coursecategories/dontshowonhome/{id}");
        return RedirectToAction(nameof(Index));
    }
}