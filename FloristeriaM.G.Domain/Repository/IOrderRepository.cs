using System.Threading.Tasks;
using FloristeriaMG.Domain.Entities;

namespace FloristeriaMG.Domain.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetOrderWithItemsAsync(int id);
    }
}
