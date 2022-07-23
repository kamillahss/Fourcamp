using FourBlog.Models;

namespace FourBlog.ViewModels
{
    public class PostVisualizarViewModel
    {
        public Postagem Post { get; set; }

        public IList<Comentario> Comentarios { get; set; }

        public int PostagemId { get; set; }

        public string Texto { get; set; }
    }
}
