using FourBlog.Models;

namespace FourBlog.Repositories
{
    public interface IPostagemRepository
    {
        public void Cadastrar(Postagem postagem);

        public void Salvar();

        public IList<Postagem> ListarPosts();

        public void CriarComentario(Comentario comentario);

        public void SalvarComentario();
    }
}
