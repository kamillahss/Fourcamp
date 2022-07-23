using FourBlog.Models;

namespace FourBlog.Repositories
{
    public interface ITagRepository
    {
        public void Criar(Tag tag);

        public void Salvar();

        public void Atualizar(Tag tag);

        public void Remover(int id);

        public Tag BuscarPorId(int id);

        public IList<Tag> ListarTags();
    }
}
