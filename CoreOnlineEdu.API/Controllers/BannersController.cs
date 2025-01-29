using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.BannerDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BannersController(IBaseService<Banner> bannerService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<Banner> result = bannerService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Banner result = bannerService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        bannerService.Delete(id);
        return Ok("Banner Silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateBannerDto createBannerDto)
    {
        Banner banner = mapper.Map<Banner>(createBannerDto);
        bannerService.Create(banner);
        return Ok("Yeni Banner Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateBannerDto updateBannerDto)
    {
        Banner banner = mapper.Map<Banner>(updateBannerDto);
        bannerService.Update(banner);
        return Ok("Banner Güncellendi");
    }
}