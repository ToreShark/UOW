using UOW.DAL.Entities;
using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class IBookRepositories : IBookRepository
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Book> GetBooks()
    {
        throw new NotImplementedException();
    }

    public Book GetBookById(Guid bookId)
    {
        throw new NotImplementedException();
    }

    public void InsertBook(Book book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(Guid bookId)
    {
        throw new NotImplementedException();
    }

    public void UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}