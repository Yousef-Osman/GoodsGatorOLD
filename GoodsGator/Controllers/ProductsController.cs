using GoodsGator.Models.DbEntities;
using GoodsGator.Repositories.Interfaces;
using GoodsGator.Specifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodsGator.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IGenericRepository<Product> _productRepo;
    private readonly IGenericRepository<Brand> _brandRepo;
    private readonly IGenericRepository<Category> _categoryRepo;

    public ProductsController(IGenericRepository<Product> productRepo,
                              IGenericRepository<Brand> brandRepo,
                              IGenericRepository<Category> CategoryRepo)
    {
        _productRepo = productRepo;
        _brandRepo = brandRepo;
        _categoryRepo = CategoryRepo;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductAsync(string id)
    {
        var spec = new ProductWithCategoryAndBrandSpec(id);
        var product = await _productRepo.GetEntityWithSpecAsync(spec);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpGet]
    public async Task<IActionResult> GetProductsAsync()
    {
        var spec = new ProductWithCategoryAndBrandSpec();
        return Ok(await _productRepo.GetAllWithSpecAsync(spec));
    }

    [HttpGet("Brands/{id}")]
    public async Task<IActionResult> GetBrandAsync(int id)
    {
        var brand = await _brandRepo.GetByIdAsync(id);
        if (brand == null || brand.IsDeleted)
            return NotFound();

        return Ok(brand);
    }

    [HttpGet("Brands")]
    public async Task<IActionResult> GetBrandsAsync()
    {
        return Ok(await _brandRepo.GetAllAsync());
    }

    [HttpGet("Categories/{id}")]
    public async Task<IActionResult> GetProductCategoryAsync(int id)
    {
        var category = await _categoryRepo.GetByIdAsync(id);

        if (category == null || category.IsDeleted)
            return NotFound();

        return Ok(category);
    }

    [HttpGet("Categories")]
    public async Task<IActionResult> GetCategoriesAsync()
    {
        return Ok(await _categoryRepo.GetAllAsync());
    }
}
