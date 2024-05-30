

using Microsoft.AspNetCore.Mvc;

public class AlumnosController : Controller
{
    public AlumnosController()
    {
    }

    public IActionResult Alumnoslist()
    {
        return View();
    }

    public IActionResult AlumnosAdd()
    {
        return View();
    }

    public IActionResult AlumnosSave()
    {
        return View();
    }
    
}