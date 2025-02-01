using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.SubscriberDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribersController(IBaseService<Subscriber> subscriberService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = subscriberService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = subscriberService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        subscriberService.Delete(id);
        return Ok("Abone Alanı silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateSubscriberDto createSubscriberDto)
    {
        var subscriber = mapper.Map<Subscriber>(createSubscriberDto);
        subscriberService.Create(subscriber);
        return Ok("Yeni Abone Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateSubscriberDto updateSubscriberDto)
    {
        var subscriber = mapper.Map<Subscriber>(updateSubscriberDto);
        subscriberService.Update(subscriber);
        return Ok("Abone Alanı Güncellendi");
    }
}