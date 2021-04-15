using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _repo;
        public ProductRepository(StoreContext repo)
        {
            _repo = repo;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _repo.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _repo.Products.ToListAsync();
        }
    }
}