namespace CoreOnlineEdu.Entity.Entities;
public class CourseRegister
{
    public int CourseRegisterId { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}