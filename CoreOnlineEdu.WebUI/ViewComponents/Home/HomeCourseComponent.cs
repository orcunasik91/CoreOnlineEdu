using CoreOnlineEdu.WebUI.Dtos.CourseDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.ViewComponents.Home;
public class HomeCourseComponent : ViewComponent
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await client.GetFromJsonAsync<List<ResultCourseDto>>("courses/GetActiveCourses");
        return View(values);
    }
}