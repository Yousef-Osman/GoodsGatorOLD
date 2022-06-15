using GoodsGator.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodsGator.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepo;

    public ProductsController(IProductRepository productRepo)
    {
        _productRepo = productRepo;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductAsync(string id)
    {
        return Ok(await _productRepo.GetProductAsync(id));
    }

    [HttpGet]
    public async Task<IActionResult> GetProductsAsync()
    {
        return Ok(await _productRepo.GetProductsAsync());
    }

    [HttpGet("Brands/{id}")]
    public async Task<IActionResult> GetBrandAsync(int id)
    {
        return Ok(await _productRepo.GetBrandAsync(id));
    }

    [HttpGet("Brands")]
    public async Task<IActionResult> GetBrandsAsync()
    {
        return Ok(await _productRepo.GetBrandsAsync());
    }

    [HttpGet("Types/{id}")]
    public async Task<IActionResult> GetProductTypeAsync(int id)
    {
        return Ok(await _productRepo.GetProductTypeAsync(id));
    }

    [HttpGet("Types")]
    public async Task<IActionResult> GetProductTypesAsync()
    {
        return Ok(await _productRepo.GetProductTypesAsync());
    }
}
