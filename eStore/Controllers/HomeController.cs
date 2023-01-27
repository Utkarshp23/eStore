using System.Diagnostics;
using eStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    // HttpContext.Session.SetString("email", null);
    // HttpContext.Session.SetString("password", null);
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }


  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
