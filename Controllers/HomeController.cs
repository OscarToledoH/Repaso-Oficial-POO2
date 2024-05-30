using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RegistrosFacultad.Models;

namespace RegistrosFacultad.Controllers;

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

    public IActionResult Carreraslist()
    {
        return View();
    }

     public IActionResult CarrerasAdd()
    {
        return View();
    }

     public IActionResult CarrerasSave()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
