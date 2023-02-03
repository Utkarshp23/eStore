using System.Diagnostics;
using BOL;
using eStore.Models;
using Microsoft.AspNetCore.Mvc;
using SAL;

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
    CustomerService cvs = new CustomerService();
    Customer c = cvs.GetCustomerByEmailAndPassword(email, password);
    // System.Console.WriteLine(c.Email + " -- " + c.Password);

    if (c == null)
      return RedirectToAction("Login", "User");
    // if (c.Email == email && c.Password == password)
    // {
    // Session[""]
    HttpContext.Session.SetString("email", c.Email);
    HttpContext.Session.SetString("password", c.Password);
    HttpContext.Session.SetString("username", c.Fname);
    return RedirectToAction("Index", "Dashboard");
    // }
    // else

  }
  
  public IActionResult Signup()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Signup(string fname, string lname, string cnum, string location, string email, string password)
  {
    // System.Console.WriteLine($"{fname} entried...");
    Customer c = new Customer { Fname = fname, Lname = lname, Cnum = cnum, Location = location, Email = email, Password = password };
    CustomerService cvs = new CustomerService();
    bool status = cvs.AddCustomer(c);
    return this.RedirectToAction("Login", "User");
  }

  public IActionResult Logout()
  {
    HttpContext.Session.Remove("email");
    HttpContext.Session.Remove("password");
    return RedirectToAction("Index", "Home");
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
