using Projeto_FourTask.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_FourTask.Models
{
    [Table("Tbl_Equipe")]
    public class Equipe
    {
        public Equipe()
        {
            DataCriacao = DateTime.Now;
        }

        [Column("Id")]
        public int EquipeId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório."), MaxLength(30)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }

        [Display(Name = "Descrição"), Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Descricao { get; set; }

        [Display(Name = "Área de atuação"), Required(ErrorMessage = "É obrigatório selecionar uma área de atuação.")]
        public AreaAtuacao AreaAtuacao { get; set; }

        [Column("Dt_Criacao"), Required, Display(Name = "Data de criação"), DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }

        public ICollection<Usuario>? Usuarios { get; set; }

        public ICollection<Tarefa>? Tarefas { get; set; }
    }

    public enum AreaAtuacao
    {
        Web, Mobile, Frontend, Backend, FullStack, Gestao, Outros
    }
}

