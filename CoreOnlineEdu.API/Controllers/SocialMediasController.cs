using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.MessageDtos;
using CoreOnlineEdu.DTO.Dtos.SocialMediaDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediasController(IBaseService<SocialMedia> socialMediaService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = socialMediaService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = socialMediaService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        socialMediaService.Delete(id);
        return Ok("Sosyal Medya Alanı silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateSocialMediaDto createSocialMediaDto)
    {
        var socialMedia = mapper.Map<SocialMedia>(createSocialMediaDto);
        socialMediaService.Create(socialMedia);
        return Ok("Yeni Sosyal Medya Alanı Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
    {
        var socialMedia = mapper.Map<SocialMedia>(updateSocialMediaDto);
        socialMediaService.Update(socialMedia);
        return Ok("Sosyal Medya Alanı Güncellendi");
    }
}