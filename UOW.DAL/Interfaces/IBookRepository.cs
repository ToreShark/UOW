using UOW.DAL.Entities;

namespace UOW.DAL.Interfaces;

public interface IBookRepository : IDisposable
{
    IEnumerable<Book> GetBooks();
    Book GetBookById(Guid bookId);
    void InsertBook(Book book);
    void DeleteBook(Guid bookId);
    void UpdateBook(Book book);
    void Save();
}