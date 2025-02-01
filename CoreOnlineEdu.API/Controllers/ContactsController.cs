using AutoMapper;
using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DTO.Dtos.ContactDtos;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreOnlineEdu.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController(IBaseService<Contact> contactService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<Contact> result = contactService.GetList();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Contact result = contactService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        contactService.Delete(id);
        return Ok("İletişim Alanı Silindi!");
    }

    [HttpPost]
    public IActionResult Create(CreateContactDto createContactDto)
    {
        Contact result = mapper.Map<Contact>(createContactDto);
        contactService.Create(result);
        return Ok("Yeni İletişim Alanı Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(UpdateContactDto updateContactDto)
    {
        Contact result = mapper.Map<Contact>(updateContactDto);
        contactService.Update(result);
        return Ok("İletişim Alanı Güncellendi");
    }
}