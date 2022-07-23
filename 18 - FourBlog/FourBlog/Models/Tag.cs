using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourBlog.Models
{
    [Table("Tbl_Tag")]
    public class Tag
    {
        [Column("Id")]
        public int TagId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        public ICollection<Postagem>? Postagem { get; set; }
    }
}
