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
        
        return BD.ObtenerSerie(IdSerie);
    }

    public List<Actores> VerDetalleActores(int IdSerie)
    {
        
        return  BD.ObtenerActores(IdSerie);
    }

    public List<Temporadas> VerDetalleTemporadas(int IdSerie)
    {
        
        return  BD.ObtenerTemporadas(IdSerie);
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
