using Microsoft.AspNetCore.Mvc;

namespace GoodsGator.Controllers;
public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetProduct(int id)
    {
        return View();
    }

    public IActionResult GetProducts()
    {
        return View();
    }
}
