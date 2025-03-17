using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.DataAccess.Abstracts;
public interface ICourseRepository : IRepository<Course>
{
    List<Course> GetCoursesWithCategory();
    void ShowOnHome(int id);
    void DontShowOnHome(int id);
}