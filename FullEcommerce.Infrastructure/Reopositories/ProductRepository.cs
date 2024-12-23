using FullEcommerce.Core.Entities;
using FullEcommerce.Core.Interfaces;
using FullEcommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FullEcommerce.Infrastructure.Reopositories
{
    public class ProductRepository : IProductReopository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Include(p => p.ProductBrand).Include(p => p.ProductType).ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetAllProductsBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetAllProductsTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.Include(p => p.ProductBrand).Include(p => p.ProductType).FirstOrDefaultAsync(p => p.Id == id);

            return product;
        }
    }
}
