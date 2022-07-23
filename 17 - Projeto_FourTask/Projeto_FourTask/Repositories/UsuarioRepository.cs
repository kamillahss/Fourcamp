using Projeto_FourTask.Areas.Identity.Data;
using System.Linq.Expressions;

namespace Projeto_FourTask.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private Projeto_FourTaskContext _context;

        public UsuarioRepository(Projeto_FourTaskContext context)
        {
            _context = context;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
        public Usuario BuscarUsuario(Expression<Func<Usuario, bool>> filtro)
        {
            return _context.Usuarios.Where(filtro).FirstOrDefault();
        }
    }
}
