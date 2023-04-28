using Microsoft.EntityFrameworkCore;
using UOW.DAL.Datas;
using UOW.DAL.Entities;
using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class BookRepository : Repository<Book>, IBookRepository
{
    private readonly AppDbContext _db;
    public BookRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
    
    public Book GetByName(string bookName)
    {
        Book book = _db.Books.FirstOrDefault(x => x.Name == bookName);
        return book;
    }

    public void Dispose()
    {
        _db.Dispose();
    }
}