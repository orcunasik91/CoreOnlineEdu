using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.BlogCategoryDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class BlogCategoryMapping : Profile
{
    public BlogCategoryMapping()
    {
        CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
        CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
    }
}