﻿namespace CoreOnlineEdu.Entity.Entities;
public class Testimonial
{
    public int TestimonialId { get; set; }
    public string FullName { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Comment { get; set; }
    public int StarPoint { get; set; }
}