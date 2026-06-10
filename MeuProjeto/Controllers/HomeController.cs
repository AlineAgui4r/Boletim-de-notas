using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;

namespace MeuProjeto.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Boletim()
    {
        var disciplinas = new List<string>
        {
            "Matemática",
            "Português",
            "História",
            "Ciências",
            "Geografia"
        };

        var notas = new List<double>
        {
            9.5,
            6.0,
            7.8,
            4.5,
            8.2
        };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}