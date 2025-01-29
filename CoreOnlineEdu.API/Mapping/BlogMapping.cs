using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.BlogDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class BlogMapping : Profile
{
    public BlogMapping()
    {
        CreateMap<ResultBlogDto, Blog>().ReverseMap();
        CreateMap<CreateBlogDto, Blog>().ReverseMap();
        CreateMap<UpdateBlogDto, Blog>().ReverseMap();
    }
}