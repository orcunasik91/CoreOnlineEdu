using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.Entity.Entities;

namespace CoreOnlineEdu.Business.Concretes;
public class BlogService : BaseService<Blog>, IBlogService
{
    private readonly IBlogRepository blogRepository;
    public BlogService(IRepository<Blog> repository, IBlogRepository _blogRepository) : base(repository)
    {
        blogRepository = _blogRepository;
    }

    public List<Blog> GetBlogsWithCategoryName()
    {
        return blogRepository.GetBlogsWithCategory();
    }
}