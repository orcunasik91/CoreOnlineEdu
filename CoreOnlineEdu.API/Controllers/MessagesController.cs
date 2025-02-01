using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.MessageDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessagesController(IBaseService<Message> messageService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = messageService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = messageService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        messageService.Delete(id);
        return Ok("Mesaj silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateMessageDto createMessageDto)
    {
        var message = mapper.Map<Message>(createMessageDto);
        messageService.Create(message);
        return Ok("Yeni Mesaj Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateMessageDto updateMessageDto)
    {
        var message = mapper.Map<Message>(updateMessageDto);
        messageService.Update(message);
        return Ok("Mesaj Güncellendi");
    }
}