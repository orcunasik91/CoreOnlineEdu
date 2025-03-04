﻿namespace CoreOnlineEdu.WebUI.Dtos.CourseDtos;
public class CreateCourseDto
{
    public string CourseName { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public bool IsShown { get; set; }
    public int CourseCategoryId { get; set; }
}
