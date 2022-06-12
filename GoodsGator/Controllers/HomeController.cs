using Microsoft.AspNetCore.Mvc;

namespace GoodsGator.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
