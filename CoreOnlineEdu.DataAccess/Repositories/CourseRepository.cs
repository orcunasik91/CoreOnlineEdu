using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.DataAccess.Context;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreOnlineEdu.DataAccess.Repositories;
public class CourseRepository : Repository<Course>, ICourseRepository
{
    public CourseRepository(OnlineEduContext _context) : base(_context)
    {
    }
    public void DontShowOnHome(int id)
    {
        var result = context.Courses.Find(id);
        result.IsShown = false;
        context.SaveChanges();
    }
    public List<Course> GetCoursesWithCategory()
    {
        return context.Courses.Include(c => c.CourseCategory).ToList();
    }
    public List<Course> GetFilterCourses()
    {
        return context.Courses.Where(c => c.IsShown.Equals(true)).ToList();
    }
    public void ShowOnHome(int id)
    {
        var result = context.Courses.Find(id);
        result.IsShown = true;
        context.SaveChanges();
    }
}