namespace UOW.DAL.Interfaces;

public interface IRepository<T> where T : class
{
    IEnumerable<T> Get();
    T GetById(Guid id);
    void Insert(T entity);
    void Update(T entity);
    void Delete(Guid id);
    void Delete(T entity);
    void Save();
}