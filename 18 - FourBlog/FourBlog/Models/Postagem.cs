using FourBlog.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourBlog.Models
{
    [Table("Tbl_Postagem")]
    public class Postagem
    {
        [Column("Id")]
        public int PostagemId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O texto é obrigatório.")]
        public string Texto { get; set; }

        [Column("Dt_Criacao"), Required]
        public DateTime DataCriacao { get; set; }

        public Postagem()
        {
            DataCriacao = DateTime.Now;
        }

        public Usuario? Usuario { get; set; }
        public string UsuarioId { get; set; }

        public Tag? Tag { get; set; }
        public int TagId { get; set; }

        public ICollection<Comentario>? Comentarios { get; set; }
    }
}
