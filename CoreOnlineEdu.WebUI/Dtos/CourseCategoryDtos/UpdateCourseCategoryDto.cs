﻿namespace CoreOnlineEdu.WebUI.Dtos.CourseCategoryDtos;
public class UpdateCourseCategoryDto
{
    public int CourseCategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Icon { get; set; }
    public string ShortDescription { get; set; }
    public bool IsShown { get; set; }
}