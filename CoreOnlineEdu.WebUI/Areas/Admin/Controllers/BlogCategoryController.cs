using CoreOnlineEdu.WebUI.Dtos.BlogCategoryDtos;
using CoreOnlineEdu.WebUI.Helpers;
using CoreOnlineEdu.WebUI.Validators;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class BlogCategoryController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogcategories");
        return View(result);
    }
    public async Task<IActionResult> RemoveBlogCategory(int id)
    {
        await client.DeleteAsync($"blogcategories/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> CreateBlogCategory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryDto createBlogCategoryDto)
    {
        var validator = new CreateBlogCategoryValidator();
        var result = await validator.ValidateAsync(createBlogCategoryDto);
        if (!result.IsValid)
        {
            ModelState.Clear();
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(createBlogCategoryDto);
        }
        await client.PostAsJsonAsync("blogcategories", createBlogCategoryDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateBlogCategory(int id)
    {
        var result = await client.GetFromJsonAsync<UpdateBlogCategoryDto>($"blogcategories/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryDto updateBlogCategoryDto)
    {
        var validator = new UpdateBlogCategoryValidator();
        var result = await validator.ValidateAsync(updateBlogCategoryDto);
        if (!result.IsValid)
        {
            ModelState.Clear();
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(updateBlogCategoryDto);
        }
        await client.PutAsJsonAsync("blogcategories", updateBlogCategoryDto);
        return RedirectToAction(nameof(Index));
    }
}