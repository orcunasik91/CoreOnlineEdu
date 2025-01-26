namespace CoreOnlineEdu.Entity.Entities;
public class CourseCategory
{
    public int CourseCategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Icon { get; set; }
    public string ShortDescription { get; set; }
    public bool IsShown { get; set; }
    public List<Course> Courses { get; set; }
}