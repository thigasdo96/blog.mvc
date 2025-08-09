using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogThiago.Models;
using System.Data;

namespace BlogThiago.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "oi mundo!";
        Categoria categoria = new();
        categoria.id = 1;
        categoria.Nome = "Tecnologia";
        Categoria categoria2 = new()
        {
            id = 2,
            Nome = "IA"
        };

        List<Postagem> postagens = [
            new() {
                Id = 1,
                Nome = "Saiu o ChatGPT 5",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "dahahfajhfjksa",
                Texto = "akdjawodkjas"
            }
        ];
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
}
