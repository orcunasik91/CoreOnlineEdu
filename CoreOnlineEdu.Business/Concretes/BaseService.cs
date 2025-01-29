using CoreOnlineEdu.Business.Abstracts;
using CoreOnlineEdu.DataAccess.Abstracts;
using System.Linq.Expressions;

namespace CoreOnlineEdu.Business.Concretes;
public class BaseService<TEntity>(IRepository<TEntity> repository) : IBaseService<TEntity> where TEntity : class
{
    public int Count()
    {
       return repository.Count();
    }

    public void Create(TEntity entity)
    {
        repository.Create(entity);
    }

    public void Delete(int id)
    {
        repository.Delete(id);
    }

    public int FilteredCount(Expression<Func<TEntity, bool>> predicate)
    {
        return repository.FilteredCount(predicate);
    }

    public TEntity GetByFilter(Expression<Func<TEntity, bool>> predicate)
    {
        return repository.GetByFilter(predicate);
    }

    public TEntity GetById(int id)
    {
        return repository.GetById(id);
    }

    public List<TEntity> GetFilteredList(Expression<Func<TEntity, bool>> predicate)
    {
        return repository.GetFilteredList(predicate);
    }

    public List<TEntity> GetList()
    {
        return repository.GetList();
    }

    public void Update(TEntity entity)
    {
        repository.Update(entity);
    }
}