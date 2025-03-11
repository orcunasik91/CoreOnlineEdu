using CoreOnlineEdu.DataAccess.Abstracts;
using CoreOnlineEdu.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CoreOnlineEdu.DataAccess.Repositories;
public class Repository<T> : IRepository<T> where T : class
{
    protected readonly OnlineEduContext context;

    public Repository(OnlineEduContext _context)
    {
        context = _context;
    }

    public DbSet<T> Table { get=> context.Set<T>(); }
    public int Count()
    {
        return Table.Count();
    }

    public void Create(T entity)
    {
        Table.Add(entity);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        T entity = GetById(id);
        Table.Remove(entity);
        context.SaveChanges();
    }

    public int FilteredCount(Expression<Func<T, bool>> predicate)
    {
        return Table.Count(predicate);
    }

    public T GetByFilter(Expression<Func<T, bool>> predicate)
    {
        return Table.FirstOrDefault(predicate);
    }

    public T GetById(int id)
    {
        return Table.Find(id);
    }

    public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).ToList();
    }

    public List<T> GetList()
    {
        return Table.ToList();
    }

    public void Update(T entity)
    {
        Table.Update(entity);
        context.SaveChanges();
    }
}