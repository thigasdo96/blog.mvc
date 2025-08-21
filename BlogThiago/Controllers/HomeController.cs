using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogThiago.Models;
using System.Data;

namespace BlogThiago.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Categoria> categorias;
    private List<Postagem> postagens;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        Categoria tecnologia = new();
        tecnologia.Id = 1;
        tecnologia.Nome = "Tecnologia";

        Categoria ia = new()
        {
            Id = 2,
            Nome = "IA"
        };
        Categoria naruto = new()
        {
            Id = 3,
            Nome = "NARUTO"
        };

        postagens = [
            new() {
                Id = 1,
                Nome = "Saiu o ChatGPT 5",
                CategoriaId = 2,
                Categoria = ia,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "dahahfajhfjksa",
                Texto = "akdjawodkjas",
                Thumbnail = "/img/paula.jpg",
                Foto = "/img/paula.jpg"
            },
            new() {
                Id = 2,
                Nome = "Naruto é muito bom",
                CategoriaId = 3,
                Categoria = naruto,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "dahahfajhfjksa",
                Texto = "akdjawodkjas",
                Thumbnail = "/img/paula.jpg",
                Foto = "/img/paula.jpg"
            },
            new() {
                Id = 3,
                Nome = "Naruto é muito bom",
                CategoriaId = 4,
                Categoria = naruto,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Naruto Clássico, também conhecido como a primeira parte do anime Naruto, refere-se aos primeiros 220 episódios da série, que contam a história de Naruto Uzumaki durante sua infância e pré-adolescência. Essa fase foca no desenvolvimento do personagem, suas relações com outros ninjas e a busca pelo reconhecimento como Hokage. ",
                Texto = "akdjawodkjas",
                Thumbnail = "/img/li.jpg",
                Foto = "/img/li.jpg"
            },
            
        ];
    }

    public IActionResult Index()
    {
        
        return View(postagens);
    }
    public IActionResult Postagem(int id)
    {
        var postagem = postagens
            .Where(p => p.Id == id)
            .SingleOrDefault();
        if (postagem == null)
            return NotFound();
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
