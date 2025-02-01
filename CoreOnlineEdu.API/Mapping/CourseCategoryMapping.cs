using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.CourseCategoryDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class CourseCategoryMapping : Profile
{
    public CourseCategoryMapping()
    {
        CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
        CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
    }
}