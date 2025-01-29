using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.BlogCategoryDtos;
using CoreOnlineEdu.DTO.Dtos.BlogDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogCategoriesController(IBaseService<BlogCategory> blogCategoryService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<BlogCategory> result = blogCategoryService.GetList();
        return Ok(result);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        BlogCategory result = blogCategoryService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        blogCategoryService.Delete(id);
        return Ok("BlogKategori Silindi!");
    }
    [HttpPost]
    public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
    {
        BlogCategory blogCategory = mapper.Map<BlogCategory>(createBlogCategoryDto);
        blogCategoryService.Create(blogCategory);
        return Ok("Yeni BlogKategori Oluşturuldu");
    }
    [HttpPut]
    public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto)
    {
        BlogCategory blogCategory = mapper.Map<BlogCategory>(updateBlogCategoryDto);
        blogCategoryService.Update(blogCategory);
        return Ok("BlogKategori Güncellendi");
    }
}