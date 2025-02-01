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
    }
}