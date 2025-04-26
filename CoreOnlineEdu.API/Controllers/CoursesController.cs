using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.CourseDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController(ICourseService courseService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = courseService.GetCoursesWithCategoryName();
        var courses = mapper.Map<List<ResultCourseWithCategoryDto>>(result);
        return Ok(courses);
    }
    [HttpGet("GetActiveCourses")]
    public IActionResult GetActiveCourses()
    {
        var result = courseService.GetActiveCourses();
        var courses = mapper.Map<List<ResultCourseDto>>(result);
        return Ok(courses);
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
    [HttpGet("ShowOnHome/{id}")]
    public IActionResult ShowOnHome(int id)
    {
        courseService.ShowOnHome(id);
        return Ok("Ana sayfada Gösteriliyor");
    }
    [HttpGet("DontShowOnHome/{id}")]
    public IActionResult DontShowOnHome(int id)
    {
        courseService.DontShowOnHome(id);
        return Ok("Ana sayfada Gösterilmiyor");
    }
}