﻿using CoreOnlineEdu.DTO.Dtos.BlogCategoryDtos;

namespace CoreOnlineEdu.DTO.Dtos.BlogDtos;
public class UpdateBlogDto
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BlogDate { get; set; }
    public int BlogCategoryId { get; set; }
}