using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.BannerDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class BannerMapping : Profile
{
    public BannerMapping()
    {
        CreateMap<CreateBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();
    }
}