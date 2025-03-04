using CoreOnlineEdu.WebUI.Dtos.BlogDtos;

namespace CoreOnlineEdu.WebUI.Dtos.BlogCategoryDtos;
public class ResultBlogCategoryDto
{
    public int BlogCategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<ResultBlogDto> Blogs { get; set; }
}