using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

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

    public IActionResult ModelCalc()
    {
        Calculation model = new Calculation();

        return View(model);
    }
    public IActionResult ViewDataCalc()
    {
        Calculation model = new Calculation();
        ViewData["Numone"] = model.Numone;
        ViewData["Numtwo"] = model.Numtwo;
        return View();
    }
    public IActionResult ViewBagCalc()
    {
        Calculation model = new Calculation();
        ViewBag.Numone = model.Numone;
        ViewBag.Numtwo = model.Numtwo;
        return View();
    }
    public IActionResult InjectionCalc()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
