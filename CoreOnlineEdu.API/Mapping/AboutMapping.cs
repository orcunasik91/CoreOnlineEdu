using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.AboutDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class AboutMapping : Profile 
{
    public AboutMapping()
    {
        CreateMap<CreateAboutDto, About>().ReverseMap();
        CreateMap<UpdateAboutDto, About>().ReverseMap();
    }
}