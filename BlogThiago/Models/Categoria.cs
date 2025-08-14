using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogThiago.Models;

public class Categoria
{
    public int Id { get; set; }
    public Categoria(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public Categoria() {}

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }
}
 