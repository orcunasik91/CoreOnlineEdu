using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.SubscriberDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class SubscriberMapping : Profile
{
    public SubscriberMapping()
    {
        CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
        CreateMap<UpdateSubscriberDto, Subscriber>().ReverseMap();
    }
}