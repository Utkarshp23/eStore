using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eStore.Models;

namespace eStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> plist= new List<Product>();
        plist.Add(new Product{Id=1,Title="Telvision",Description="internet tv",Unitprice=100000.0,Stockavailable=10});
        plist.Add(new Product{Id=2,Title="Mobile",Description="internet tv",Unitprice=100000.0,Stockavailable=10});
        plist.Add(new Product{Id=3,Title="laptop",Description="internet tv",Unitprice=100000.0,Stockavailable=10});
        return View(plist);
    }

    

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
