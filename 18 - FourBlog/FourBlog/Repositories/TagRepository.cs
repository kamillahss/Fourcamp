using FourBlog.Areas.Identity.Data;
using FourBlog.Models;

namespace FourBlog.Repositories
{
    public class TagRepository : ITagRepository
    {
        private FourBlogContext _context;

        public TagRepository(FourBlogContext context)
        {
            _context = context;
        }
        public void Atualizar(Tag tag)
        {
            _context.Tags.Update(tag);
        }

        public Tag BuscarPorId(int id)
        {
            return _context.Tags.Find(id);
        }

        public void Criar(Tag tag)
        {
            _context.Tags.Add(tag);
        }

        public IList<Tag> ListarTags()
        {
            return _context.Tags.ToList();
        }

        public void Remover(int id)
        {
            Tag tag = _context.Tags.Find(id);
            _context.Tags.Remove(tag);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
