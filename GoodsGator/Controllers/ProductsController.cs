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
    private readonly IGenericRepository<ProductType> _typeRepo;

    public ProductsController(IGenericRepository<Product> productRepo,
                              IGenericRepository<Brand> brandRepo,
                              IGenericRepository<ProductType> typeRepo)
    {
        _productRepo = productRepo;
        _brandRepo = brandRepo;
        _typeRepo = typeRepo;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductAsync(string id)
    {
        var spec = new ProductWIthTypeAndBrandSpec();
        return Ok(await _productRepo.GetEntityWithSpecAsync(spec));
    }

    [HttpGet]
    public async Task<IActionResult> GetProductsAsync()
    {
        var spec = new ProductWIthTypeAndBrandSpec();
        return Ok(await _productRepo.GetAllWithSpecAsync(spec));
    }

    [HttpGet("Brands/{id}")]
    public async Task<IActionResult> GetBrandAsync(int id)
    {
        return Ok(await _brandRepo.GetByIdAsync(id));
    }

    [HttpGet("Brands")]
    public async Task<IActionResult> GetBrandsAsync()
    {
        return Ok(await _brandRepo.GetAllAsync());
    }

    [HttpGet("Types/{id}")]
    public async Task<IActionResult> GetProductTypeAsync(int id)
    {
        return Ok(await _typeRepo.GetByIdAsync(id));
    }

    [HttpGet("Types")]
    public async Task<IActionResult> GetProductTypesAsync()
    {
        return Ok(await _typeRepo.GetAllAsync());
    }
}
