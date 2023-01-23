using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eStore.Models;
using SAL;
using BOL;

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
        ProductHubService svc=new ProductHubService();
        List<Product> plist= svc.GetAllProducts();
        this.ViewData["products"]=plist;
        return View();
    }

    public IActionResult Insertform()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
         ProductHubService svc=new ProductHubService();
         Product p= svc.GetProductById(id);
         
         this.ViewData["prod"]=p;
         return View();
    }

    [HttpPost]
    public IActionResult Insert(int pid,string title,string desc,int uprice,int saval,string cat)
    {
        Product p=new Product{ProductId = pid, Title = title, Description = desc, UnitPrice = uprice , StockAvailable = saval, Category = cat};
        ProductHubService svc= new ProductHubService();
        bool status= svc.AddProduct(p);
        return this.RedirectToAction("Index","Products");
    }

    

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
