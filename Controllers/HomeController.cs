using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Series.Models;

namespace TP_Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public Series VerDetalleSeries(int IdSerie)
    {
        ViewBag.MostrarSerie = BD.ObtenerSerie(IdSerie);
        return ViewBag.MostrarSerie;
    }

    public List<Actores> VerDetalleActores(int IdSerie)
    {
        ViewBag.MostrarActores = BD.ObtenerActores(IdSerie);
        return ViewBag.MostrarActores;
    }

    public List<Temporadas> VerDetalleTemporadas(int IdSerie)
    {
        ViewBag.MostrarTemporadas = BD.ObtenerTemporadas(IdSerie);
        return ViewBag.MostrarTemporadas;
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
