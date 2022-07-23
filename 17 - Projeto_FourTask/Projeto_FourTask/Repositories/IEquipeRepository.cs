using Projeto_FourTask.Areas.Identity.Data;
using Projeto_FourTask.Models;
using System.Linq.Expressions;

namespace Projeto_FourTask.Repositories
{
    public interface IEquipeRepository
    {
        public void Cadastrar(Equipe equipe);

        public void AtualizarEquipe(Equipe equipe);

        public void Salvar();

        public IList<Equipe> ListarEquipe();

        Equipe BuscarEquipe(Expression<Func<Usuario, bool>> filtro);
    }
}
