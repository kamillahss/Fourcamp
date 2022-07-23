using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FourBlog.Models;
using Microsoft.AspNetCore.Identity;

namespace FourBlog.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Usuario class
public class Usuario : IdentityUser
{
    [Required]
    public string Nome { get; set; }

    [Column("Dt_Nascimento"), Required]
    public DateTime DataNascimento { get; set; }

    public ICollection<Postagem>? Postagens { get; set; }

    public ICollection<Comentario>? Comentarios { get; set; }
}

