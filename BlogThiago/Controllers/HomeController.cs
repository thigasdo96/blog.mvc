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
        Categoria tecnologia = new();
        tecnologia.Id = 1;
        tecnologia.Nome = "Tecnologia";
        
        Categoria ia = new()
        {
            Id = 2,
            Nome = "IA"
        };

        List<Postagem> postagens = [
            new() {
                Id = 1,
                Nome = "Saiu o ChatGPT 5",
                CategoriaId = 2,
                Categoria = ia,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "dahahfajhfjksa",
                Texto = "akdjawodkjas",
                Thumbnail = "/img/pula.jpg",
                Foto = "/img/pula.jpg"
            }
        ];
        return View(postagens);
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
