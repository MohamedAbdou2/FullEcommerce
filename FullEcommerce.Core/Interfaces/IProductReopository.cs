using FullEcommerce.Core.Entities;

namespace FullEcommerce.Core.Interfaces
{
    public interface IProductReopository
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetAllProductsBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetAllProductsTypesAsync();

        Task<Product?> GetProductByIdAsync(int id);
    }
}
