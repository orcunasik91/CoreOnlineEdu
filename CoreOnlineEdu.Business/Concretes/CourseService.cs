using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.Business.Concretes;
public class CourseService : BaseService<Course>, ICourseService
{
    private readonly ICourseRepository courseRepository;
    public CourseService(IRepository<Course> repository, ICourseRepository courseRepository) : base(repository)
    {
        this.courseRepository = courseRepository;
    }
    public void DontShowOnHome(int id)
    {
        courseRepository.DontShowOnHome(id);
    }
    public List<Course> GetActiveCourses()
    {
        return courseRepository.GetFilterCourses();
    }
    public List<Course> GetCoursesWithCategoryName()
    {
        return courseRepository.GetCoursesWithCategory();
    }
    public void ShowOnHome(int id)
    {
        courseRepository.ShowOnHome(id);
    }
}