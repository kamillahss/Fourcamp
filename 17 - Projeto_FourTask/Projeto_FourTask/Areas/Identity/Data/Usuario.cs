using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Projeto_FourTask.Models;

namespace Projeto_FourTask.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Usuario class
//O nome da tabela Usuario no BD é AspNetUsers
public class Usuario : IdentityUser
{
    [Required]
    public string Nome { get; set; }

    [Required, Column("Dt_Nascimento")]
    public DateTime DataNascimento { get; set; }

    public Equipe? Equipe { get; set; }

    public int? EquipeId { get; set; }

    public ICollection<Tarefa>? Tarefas { get; set; }
}

