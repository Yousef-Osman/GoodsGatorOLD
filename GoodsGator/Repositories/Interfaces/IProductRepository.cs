using GoodsGator.Models.DbEntities;

namespace GoodsGator.Repositories.Interfaces;

public interface IProductRepository
{
    Task<Product> GetProductAsync(string id); 
    Task<IReadOnlyList<Product>> GetProductsAsync();
    Task<Brand> GetBrandAsync(int id);
    Task<IReadOnlyList<Brand>> GetBrandsAsync();
    Task<ProductType> GetProductTypeAsync(int id);
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
}
