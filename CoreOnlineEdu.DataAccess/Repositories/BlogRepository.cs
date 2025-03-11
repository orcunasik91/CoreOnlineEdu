using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.DataAccess.Context;
using CoreOnlineEdu.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreOnlineEdu.DataAccess.Repositories;
public class BlogRepository : Repository<Blog>, IBlogRepository
{
    public BlogRepository(OnlineEduContext context) : base(context)
    {
    }

    public List<Blog> GetBlogsWithCategory()
    {
        return context.Blogs.Include(b => b.BlogCategory).ToList();
    }
}