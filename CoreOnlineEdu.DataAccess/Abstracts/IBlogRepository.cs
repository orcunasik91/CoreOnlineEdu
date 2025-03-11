using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.DataAccess.Abstracts;
public interface IBlogRepository : IRepository<Blog>
{
    List<Blog> GetBlogsWithCategory();
}