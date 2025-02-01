using AutoMapper;
using CoreOnlineEdu.DTO.Dtos.TestimonialDtos;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.API.Mapping;
public class TestimonialMapping : Profile
{
    public TestimonialMapping()
    {
        CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
        CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
    }
}