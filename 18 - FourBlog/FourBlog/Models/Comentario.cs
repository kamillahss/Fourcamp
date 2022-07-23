using FourBlog.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourBlog.Models
{
    [Table("Tbl_Comentario")]
    public class Comentario
    {
        [Column("Id")]
        public int ComentarioId { get; set; }

        [Required(ErrorMessage = "Insira um comentário.")]
        public string Texto { get; set; }

        [Column("Dt_Hora"), Required]
        public DateTime DataHora { get; set; }

        public Comentario()
        {
          DataHora = DateTime.Now;
        }

        public Usuario Usuario { get; set; }
        public string? UsuarioId { get; set; }

        public Postagem Postagem { get; set; }
        public int PostagemId { get; set; }
    }
}
