using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.DataAccess.Context;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.DataAccess.Repositories;
public class CourseCategoryRepository : Repository<CourseCategory>, ICourseCategoryRepository
{
    public CourseCategoryRepository(OnlineEduContext _context) : base(_context)
    {
    }

    public void DontShowOnHome(int id)
    {
        var result = context.CourseCategories.Find(id);
        result.IsShown = false;
        context.SaveChanges();
    }

    public List<CourseCategory> GetFilterCourseCategories()
    {
        return context.CourseCategories.Where(cc => cc.IsShown.Equals(true)).ToList();
    }

    public void ShowOnHome(int id)
    {
        var result = context.CourseCategories.Find(id);
        result.IsShown = true;
        context.SaveChanges();
    }
}