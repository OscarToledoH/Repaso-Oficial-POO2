

using Microsoft.AspNetCore.Mvc;

public class MaestrosController : Controller
{
    public MaestrosController()
    {
    }

    public IActionResult Maestroslist()
    {
        return View();
    }

    public IActionResult MaestrosAdd()
    {
        return View();
    }

    public IActionResult MaestrosSave()
    {
        return View();
    }
}