using Microsoft.EntityFrameworkCore;
using Projeto_FourTask.Areas.Identity.Data;
using Projeto_FourTask.Models;
using System.Linq.Expressions;

namespace Projeto_FourTask.Repositories
{
    public class EquipeRepository : IEquipeRepository
    {
        private Projeto_FourTaskContext _context;

        public EquipeRepository(Projeto_FourTaskContext context)
        {
            _context = context;
        }

        public void AtualizarEquipe(Equipe equipe)
        {
            _context.Equipes.Update(equipe);
        }

        public void Cadastrar(Equipe equipe)
        {
            _context.Equipes.Add(equipe);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public IList<Equipe> ListarEquipe()
        {
            return _context.Equipes.ToList();
        }

        public Equipe BuscarEquipe(Expression<Func<Usuario, bool>> filtro)
        {
            return _context.Usuarios.Where(filtro).Include(usuario => usuario.Equipe).Select(usuario => usuario.Equipe).FirstOrDefault();
        }

    }
}
