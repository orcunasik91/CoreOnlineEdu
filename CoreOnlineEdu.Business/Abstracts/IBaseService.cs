using System.Linq.Expressions;

namespace CoreOnlineEdu.Business.Abstracts;
public interface IBaseService<TEntity> where TEntity : class
{
    List<TEntity> GetList();
    List<TEntity> GetFilteredList(Expression<Func<TEntity, bool>> predicate);
    TEntity GetById(int id);
    TEntity GetByFilter(Expression<Func<TEntity, bool>> predicate);
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
    int Count();
    int FilteredCount(Expression<Func<TEntity, bool>> predicate);
}
