namespace CoreOnlineEdu.Entity.Entities;
public class BlogCategory
{
    public int BlogCategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<Blog> Blogs { get; set; }
}