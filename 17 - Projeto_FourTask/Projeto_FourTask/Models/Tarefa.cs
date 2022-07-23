using Microsoft.AspNetCore.Authorization;
using Projeto_FourTask.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_FourTask.Models
{
    [Authorize]
    [Table("Tbl_Tarefa")]
    public class Tarefa
    {
        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        [Column("Id")]
        public int TarefaId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição"), Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Descricao { get; set; }

        [Column("Dt_Criacao"), Required, Display(Name = "Data de criação"), DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }

        [Column("Dt_Limite"), Required(ErrorMessage = "A data limite é obrigatória."), Display(Name = "Data limite"), DataType(DataType.Date)]
        public DateTime DataLimite { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma equipe.")]
        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }

        public Usuario? Usuario { get; set; }
        public string? UsuarioId { get; set; }
    }
}
