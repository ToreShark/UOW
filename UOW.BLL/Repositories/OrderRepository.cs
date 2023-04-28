using UOW.DAL.Datas;
using UOW.DAL.Entities;
using UOW.DAL.Interfaces;

namespace UOW.BLL.Repositories;

public class OrderRepository : Repository<Orders>, IOrderRepository
{
    private readonly AppDbContext _db;
    public OrderRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}