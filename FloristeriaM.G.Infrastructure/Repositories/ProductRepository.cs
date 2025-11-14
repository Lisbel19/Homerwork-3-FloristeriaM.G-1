using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FloristeriaMG.Domain.Entities;
using FloristeriaMG.Domain.Repository;
using FloristeriaMG.Infrastructure.Context;

namespace FloristeriaMG.Infrastructure.Repositories
{
    public class ProductRepository : Core.BaseRepository<Product>, IProductRepository
    {
        private readonly FloristeriaContext _ctx;

        public ProductRepository(FloristeriaContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<Product>> GetByOccasionAsync(int occasionId)
        {
            return await _ctx.Products
                .Where(p => p.OccasionId == occasionId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetNearExpirationAsync(int days)
        {
            var limit = DateTime.UtcNow.AddDays(days);
            return await _ctx.Products
                .Where(p => p.ExpirationDate.HasValue && p.ExpirationDate <= limit)
                .ToListAsync();
        }
    }
}
