using FourBlog.Areas.Identity.Data;
using FourBlog.Models;

namespace FourBlog.Repositories
{
    public class PostagemRepository : IPostagemRepository
    {
        private FourBlogContext _context;

        public PostagemRepository(FourBlogContext context)
        {
            _context = context;
        }
        public void Cadastrar(Postagem postagem)
        {
            _context.Postagens.Add(postagem);
        }

        public void CriarComentario(Comentario comentario)
        {
            _context.Comentarios.Add(comentario);
        }

        public IList<Postagem> ListarPosts()
        {
            return _context.Postagens.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void SalvarComentario()
        {
            _context.SaveChanges();
        }
    }
}
