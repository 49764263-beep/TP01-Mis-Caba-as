using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using misCabañas.Models;

namespace misCabañas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Complejo residencia = new Complejo();
        ViewBag.Complejo = residencia;
        return View();
    }
    public IActionResult SelectCabania(int id)
    {
        Complejo residencia = new Complejo();
        Cabania EnLista = residencia.GetCabania(id);
        ViewBag.Cabania = EnLista;
        ViewBag.IDCabania = id;
        return View("infoCabania"); 
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
