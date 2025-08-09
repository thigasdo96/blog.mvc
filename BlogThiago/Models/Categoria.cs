using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogThiago.Models;

public class Categoria
{
    public int id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }
}
