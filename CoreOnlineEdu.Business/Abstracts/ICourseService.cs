using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.Business.Abstracts;
public interface ICourseService : IBaseService<Course>
{
    void ShowOnHome(int id);
    void DontShowOnHome(int id);
    List<Course> GetCoursesWithCategoryName();
}