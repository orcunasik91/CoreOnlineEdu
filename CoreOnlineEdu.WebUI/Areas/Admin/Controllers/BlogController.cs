using CoreOnlineEdu.WebUI.Dtos.BlogCategoryDtos;
using CoreOnlineEdu.WebUI.Dtos.BlogDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreOnlineEdu.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class BlogController : Controller
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    public async Task CategoryDropDownAsync()
    {
        var categoryList = await client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogcategories");
        List<SelectListItem> categories = (from c in categoryList
                                           select new SelectListItem
                                           {
                                               Value = c.BlogCategoryId.ToString(),
                                               Text = c.CategoryName
                                           }).ToList();
        ViewBag.Categories = categories;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await client.GetFromJsonAsync<List<ResultBlogDto>>("blogs");
        return View(result);
    }
    public async Task<IActionResult> RemoveBlog(int id)
    {
        await client.DeleteAsync($"blogs/{id}");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> CreateBlog()
    {
        await CategoryDropDownAsync();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
    {
        await client.PostAsJsonAsync("blogs", createBlogDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> UpdateBlog(int id)
    {
        await CategoryDropDownAsync();
        var result = await client.GetFromJsonAsync<UpdateBlogDto>($"blogs/{id}");
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
    {
        await client.PutAsJsonAsync("blogs", updateBlogDto);
        return RedirectToAction(nameof(Index));
    }
}