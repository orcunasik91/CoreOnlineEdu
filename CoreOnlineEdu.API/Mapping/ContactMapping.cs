using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.ContactDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<CreateContactDto, Contact>().ReverseMap();
        CreateMap<UpdateContactDto, Contact>().ReverseMap();
    }
}