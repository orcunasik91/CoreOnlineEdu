using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.AboutDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController(IBaseService<About> aboutService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<About> result = aboutService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        About result = aboutService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        aboutService.Delete(id);
        return Ok("Hakkımızda Alanı Silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateAboutDto createAboutDto)
    {
        About about = mapper.Map<About>(createAboutDto);
        aboutService.Create(about);
        return Ok("Yeni Hakkımızda Alanı Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateAboutDto updateAboutDto)
    {
        About about = mapper.Map<About>(updateAboutDto);
        aboutService.Update(about);
        return Ok("Hakkımızda Alanı Güncellendi");
    }
}