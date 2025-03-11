using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.BlogDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogsController(IBlogService blogService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = blogService.GetBlogsWithCategoryName();
        var blogs = mapper.Map<List<ResultBlogDto>>(result);
        return Ok(blogs);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Blog result = blogService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        blogService.Delete(id);
        return Ok("Blog Silindi!");
    }
    [HttpPost]
    public IActionResult Create(CreateBlogDto createBlogDto)
    {
        Blog blog = mapper.Map<Blog>(createBlogDto);
        blogService.Create(blog);
        return Ok("Yeni Blog Oluşturuldu");
    }
    [HttpPut]
    public IActionResult Update(UpdateBlogDto updateBlogDto)
    {
        Blog blog = mapper.Map<Blog>(updateBlogDto);
        blogService.Update(blog);
        return Ok("Blog Güncellendi");
    }
}