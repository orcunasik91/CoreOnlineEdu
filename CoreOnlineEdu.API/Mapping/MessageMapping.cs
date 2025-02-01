using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.MessageDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class MessageMapping : Profile
{
    public MessageMapping()
    {
        CreateMap<CreateMessageDto, Message>().ReverseMap();
        CreateMap<UpdateMessageDto, Message>().ReverseMap();
    }
}