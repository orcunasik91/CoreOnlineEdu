using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.Business.Abstracts;
public interface IBlogService : IBaseService<Blog>
{
    List<Blog> GetBlogsWithCategoryName();
}