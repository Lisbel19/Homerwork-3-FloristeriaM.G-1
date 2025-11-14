using System.Collections.Generic;
using System.Threading.Tasks;
using FloristeriaMG.Domain.Entities;

namespace FloristeriaMG.Domain.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetByOccasionAsync(int occasionId);
        Task<IEnumerable<Product>> GetNearExpirationAsync(int days);
    }
}
