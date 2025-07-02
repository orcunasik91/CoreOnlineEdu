﻿using CoreOnlineEdu.Entity.Entities;
using CoreOnlineEdu.WebUI.Dtos.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace CoreOnlineEdu.WebUI.Services.UserServices;
public class UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : IUserService
{
    public Task<bool> AssignRoleAsync(AssignRoleDto assignRoleDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CreateRoleAsync(UserRoleDto userRoleDto)
    {
        throw new NotImplementedException();
    }

    public async Task<IdentityResult> CreateUserAsync(UserRegisterDto userRegisterDto)
    {
        var user = new AppUser
        {
            FirstName = userRegisterDto.FirstName,
            LastName = userRegisterDto.LastName,
            UserName = userRegisterDto.UserName,
            Email = userRegisterDto.Email
        };
        if (userRegisterDto.Password != userRegisterDto.ConfirmPassword)
            return new IdentityResult();
        return await userManager.CreateAsync(user, userRegisterDto.Password);
    }

    public Task<bool> LoginAsync(UserLoginDto userLoginDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> LogoutAsync()
    {
        throw new NotImplementedException();
    }
}