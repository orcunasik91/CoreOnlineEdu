using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.SocialMediaDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class SocialMediaMapping : Profile
{
    public SocialMediaMapping()
    {
        CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
        CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
    }
}