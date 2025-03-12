using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.Business.Abstracts;
public interface ICourseCategoryService : IBaseService<CourseCategory>
{
    void ShowOnHome(int id);
    void DontShowOnHome(int id);
}