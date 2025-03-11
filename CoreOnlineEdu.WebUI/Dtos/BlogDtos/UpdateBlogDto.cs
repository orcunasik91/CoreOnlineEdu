using CoreOnlineEdu.WebUI.Dtos.BlogCategoryDtos;

namespace CoreOnlineEdu.WebUI.Dtos.BlogDtos;
public class UpdateBlogDto
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BlogDate { get; set; } = DateTime.Now;
    public int BlogCategoryId { get; set; }
}