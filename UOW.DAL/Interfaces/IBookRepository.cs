using System.Collections;
using UOW.DAL.Entities;

namespace UOW.DAL.Interfaces;

public interface IBookRepository : IRepository<Book>, IDisposable
{
    Book GetByName(string bookName);
}
