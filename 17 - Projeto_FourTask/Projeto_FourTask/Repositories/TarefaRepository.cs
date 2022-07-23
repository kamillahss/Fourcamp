using Microsoft.EntityFrameworkCore;
using Projeto_FourTask.Areas.Identity.Data;
using Projeto_FourTask.Models;

namespace Projeto_FourTask.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {

        private Projeto_FourTaskContext _context;

        public TarefaRepository(Projeto_FourTaskContext context)
        {
            _context = context;
        }

        public void Criar(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Atualizar(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
        }

        public void Remover(int id)
        {
            Tarefa tarefa = _context.Tarefas.Find(id);
            _context.Tarefas.Remove(tarefa);
        }

        public Tarefa BuscarPorId(int id)
        {
            return _context.Tarefas.Include(a => a.Equipe).Where(a => a.TarefaId == id).FirstOrDefault();
        }
        public IList<Tarefa> ListarTarefas()
        {
            return _context.Tarefas.Include(t => t.Equipe).ToList();
        }
    }
}
