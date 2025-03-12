using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.Business.Concretes;
using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.DataAccess.Repositories;

namespace CoreOnlineEdu.API.Extensions;
public static class ServiceRegistrations
{
    public static IServiceCollection AddServiceRegistrations(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        services.AddScoped<IBlogRepository, BlogRepository>();
        services.AddScoped<IBlogService, BlogService>();
        services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
        services.AddScoped<ICourseCategoryService, CourseCategoryService>();
        return services;
    }
}