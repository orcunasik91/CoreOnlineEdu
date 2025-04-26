using CoreOnlineEdu.WebUI.Dtos.BannerDtos;
using CoreOnlineEdu.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.ViewComponents.Home;
public class HomeBannerComponent : ViewComponent
{
    private readonly HttpClient client = HttpClientInstance.CreateClient();
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
        return View(values);
    }
}