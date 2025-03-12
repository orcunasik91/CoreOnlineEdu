using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.DataAccess.Abstracts;
public interface ICourseCategoryRepository : IRepository<CourseCategory>
{
    void ShowOnHome(int id);
    void DontShowOnHome(int id);
}