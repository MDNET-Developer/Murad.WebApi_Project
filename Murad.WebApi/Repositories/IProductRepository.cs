using Murad.WebApi.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Murad.WebApi.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(int id);
        public Task<Product> CreateAsync(Product product);
        public Task Remove(int id);
        public Task UpdateAsync(Product produc);
    }
}
