using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mi_Web_mvc.Models;

namespace Mi_Web_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Nombre = Datos.Nombre;
        ViewBag.Titulo = Datos.Titulo;
        ViewBag.SobreMi = Datos.SobreMi;
        ViewBag.Proyectos = Datos.Proyectos;
        ViewBag.Certificados = Datos.Certificados;
        ViewBag.Idiomas = Datos.Idiomas;

        return View();
    }

        public IActionResult Proyectos()
    {
        return View("Proyectos");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { });
    }
}