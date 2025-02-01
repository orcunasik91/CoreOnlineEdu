using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.CourseDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController(IBaseService<Course> courseService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = courseService.GetList();
        return Ok(result);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Course result = courseService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        courseService.Delete(id);
        return Ok("Kurs Silindi!");
    }
    [HttpPost]
    public IActionResult Create(CreateCourseDto createCourseDto)
    {
        Course course = mapper.Map<Course>(createCourseDto);
        courseService.Create(course);
        return Ok("Yeni Kurs Oluşturuldu");
    }
    [HttpPut]
    public IActionResult Update(UpdateCourseDto updateCourseDto)
    {
        Course course = mapper.Map<Course>(updateCourseDto);
        courseService.Update(course);
        return Ok("Kurs Güncellendi");
    }
}