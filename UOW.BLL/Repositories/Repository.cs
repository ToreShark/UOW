using Microsoft.EntityFrameworkCore;
using UOW.DAL.Datas;
using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _db;
    private readonly DbSet<T> dbSet;
    public Repository(AppDbContext db)
    {
        _db = db; 
        dbSet = _db.Set<T>();
    }
    public IEnumerable<T> Get()
    {
        return dbSet.ToList();
    }

    public T GetById(Guid id)
    {
        T entity = dbSet.Find(id);
        if (entity == null)
        {
            throw new Exception("Not found");
        }
        return entity;
    }

    public void Insert(T entity)
    {
        dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        dbSet.Attach(entity);
        _db.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(Guid id)
    {
        T entityDelete = dbSet.Find(id);
        if (entityDelete == null)
        {
            throw new Exception("Not found");
        }
        dbSet.Remove(entityDelete);
    }
    public void Delete(T entity)
    {
        if (_db.Entry(entity).State == EntityState.Detached)
        {
            dbSet.Attach(entity);
        }
        dbSet.Remove(entity);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}