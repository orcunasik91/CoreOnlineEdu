using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.SubscriberDtos;
using CoreOnlineEdu.DTO.Dtos.TestimonialDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimonialsController(IBaseService<Testimonial> testimonialService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = testimonialService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = testimonialService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        testimonialService.Delete(id);
        return Ok("Referans Alanı silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateTestimonialDto createTestimonialDto)
    {
        var testimonial = mapper.Map<Testimonial>(createTestimonialDto);
        testimonialService.Create(testimonial);
        return Ok("Yeni Referans Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
    {
        var testimonial = mapper.Map<Testimonial>(updateTestimonialDto);
        testimonialService.Update(testimonial);
        return Ok("Referans Alanı Güncellendi");
    }
}