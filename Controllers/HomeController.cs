using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using renginiu_sistema.Models;

namespace renginiu_sistema.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    // Action for creating a discount code
    public ActionResult Discount()
    {
        return View();
    }

    // Action for writing a report
    public ActionResult Report()
    {
        return View();
    }

    // Action for editing user profile data
    public ActionResult EditUser()
    {
        return View();
    }

    public IActionResult RegistrationOrg()
    {
        return View();
    }

    // Save action for each form
    [HttpPost]
    public ActionResult SaveChanges(string message)
    {
        TempData["SuccessMessage"] = message;
        return RedirectToAction("Index", "Home"); // Redirect to main page
    }

}
