using CoreOnlineEdu.WebUI.Dtos.UserDtos;
using CoreOnlineEdu.WebUI.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.WebUI.Controllers;
public class RegisterController(IUserService userService) : Controller
{
    [HttpGet]
    public IActionResult Signup()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Signup(UserRegisterDto userRegisterDto)
    {
        var result = await userService.CreateUserAsync(userRegisterDto);
        if (!result.Succeeded || !ModelState.IsValid)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View();
        }
        return RedirectToAction("Index","Login");
    }
}