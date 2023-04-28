using UOW.DAL.Entities;
namespace UOW.DAL.Interfaces;

public interface IOrderRepository : IRepository<Orders>, IDisposable
{
    
}