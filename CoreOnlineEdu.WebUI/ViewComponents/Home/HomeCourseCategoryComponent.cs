using CoreOnlineEdu.WebUI.Dtos.CourseCategoryDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.ViewComponents.Home;
public class HomeCourseCategoryComponent : ViewComponent
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("coursecategories/GetActiveCourseCategories");
        return View(values);
    }
}