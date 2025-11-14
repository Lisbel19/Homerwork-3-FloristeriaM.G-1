using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FloristeriaMG.Domain.Entities;
using FloristeriaMG.Domain.Repository;
using FloristeriaMG.Infrastructure.Context;

namespace FloristeriaMG.Infrastructure.Repositories
{
    public class OrderRepository : Core.BaseRepository<Order>, IOrderRepository
    {
        private readonly FloristeriaContext _ctx;

        public OrderRepository(FloristeriaContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public async Task<Order> GetOrderWithItemsAsync(int id)
        {
            return await _ctx.Orders
                .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                .Include(o => o.Client)
                .FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}
