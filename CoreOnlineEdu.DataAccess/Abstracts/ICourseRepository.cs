using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.DataAccess.Abstracts;
public interface ICourseRepository : IRepository<Course>
{
    List<Course> GetCoursesWithCategory();
    List<Course> GetFilterCourses();
    void ShowOnHome(int id);
    void DontShowOnHome(int id);
}