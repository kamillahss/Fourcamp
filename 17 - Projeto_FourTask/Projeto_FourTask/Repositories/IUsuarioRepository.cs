using Projeto_FourTask.Areas.Identity.Data;
using System.Linq.Expressions;

namespace Projeto_FourTask.Repositories
{
    public interface IUsuarioRepository
    {
        public void AtualizarUsuario(Usuario usuario);
        public void Salvar();

        public Usuario BuscarUsuario(Expression<Func<Usuario, bool>> filtro);
    }
}
