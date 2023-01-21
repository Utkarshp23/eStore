using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eStore.Models;

namespace eStore.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
      if(email=="utkarshpawar2332@gmail.com" && password=="root1234")
      {
        Response.Redirect("/dashboard/index");
      }
      return View();
    }


    public IActionResult Signup()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Signup(string fname,string lname,string cnum, string location, string email, string password)
    {
      System.Console.WriteLine($"{fname} entried...");
      return this.RedirectToAction("Login","User");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
