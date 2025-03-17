using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.CourseDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class CourseMapping : Profile
{
    public CourseMapping()
    {
        CreateMap<CreateCourseDto, Course>().ReverseMap();
        CreateMap<UpdateCourseDto, Course>().ReverseMap();
        CreateMap<Course, ResultCourseDto>().ReverseMap();
        CreateMap<Course, ResultCourseWithCategoryDto>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CourseCategory.CategoryName))
            .ReverseMap();
    }
}