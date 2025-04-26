using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.Business.Concretes;
public class CourseCategoryService : BaseService<CourseCategory>, ICourseCategoryService
{
    private readonly ICourseCategoryRepository courseCategoryRepository;
    public CourseCategoryService(IRepository<CourseCategory> repository, ICourseCategoryRepository courseCategoryRepository) : base(repository)
    {
        this.courseCategoryRepository = courseCategoryRepository;
    }

    public void DontShowOnHome(int id)
    {
        courseCategoryRepository.DontShowOnHome(id);
    }

    public List<CourseCategory> GetActiveCourseCategories()
    {
        return courseCategoryRepository.GetFilterCourseCategories();
    }

    public void ShowOnHome(int id)
    {
        courseCategoryRepository.ShowOnHome(id);
    }
}