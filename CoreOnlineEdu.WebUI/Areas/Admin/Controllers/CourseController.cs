using CoreOnlineEdu.WebUI.Dtos.CourseCategoryDtos;
using CoreOnlineEdu.WebUI.Dtos.CourseDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class CourseController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    public async Task CategoryDropDownAsync()
    {
        var categoryList = await client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("coursecategories");
        List<SelectListItem> categories = (from c in categoryList
                                           select new SelectListItem
                                           {
                                               Value = c.CourseCategoryId.ToString(),
                                               Text = c.CategoryName
                                           }).ToList();
        ViewBag.Categories = categories;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultCourseDto>>("Courses");
        return View(result);
    }
    public async Task<IActionResult> RemoveCourse(int id)
    {
        await client.DeleteAsync($"Courses/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> CreateCourse()
    {
        await CategoryDropDownAsync();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCourse(CreateCourseDto createCourseDto)
    {
        await client.PostAsJsonAsync("Courses", createCourseDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateCourse(int id)
    {
        await CategoryDropDownAsync();
        var result = await client.GetFromJsonAsync<UpdateCourseDto>($"Courses/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateCourse(UpdateCourseDto updateCourseDto)
    {
        await client.PutAsJsonAsync("Courses", updateCourseDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> ShowOnHomeCourse(int id)
    {
        await client.GetAsync($"courses/showonhome/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> DontShowOnHomeCourse(int id)
    {
        await client.GetAsync($"courses/dontshowonhome/{id}");
        return RedirectToAction(nameof(Index));
    }
}