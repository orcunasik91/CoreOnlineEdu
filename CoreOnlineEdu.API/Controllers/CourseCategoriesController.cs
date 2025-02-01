using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.CourseCategoryDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseCategoriesController(IBaseService<CourseCategory> courseCategoryService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<CourseCategory> result = courseCategoryService.GetList();
        return Ok(result);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        CourseCategory result = courseCategoryService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        courseCategoryService.Delete(id);
        return Ok("KursKategori Silindi!");
    }
    [HttpPost]
    public IActionResult Create(CreateCourseCategoryDto createCourseCategoryDto)
    {
        CourseCategory courseCategory = mapper.Map<CourseCategory>(createCourseCategoryDto);
        courseCategoryService.Create(courseCategory);
        return Ok("Yeni KursKategori Oluşturuldu");
    }
    [HttpPut]
    public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
    {
        CourseCategory courseCategory = mapper.Map<CourseCategory>(updateCourseCategoryDto);
        courseCategoryService.Update(courseCategory);
        return Ok("KursKategori Güncellendi");
    }
}