using Projeto_FourTask.Models;

namespace Projeto_FourTask.Repositories
{
    public interface ITarefaRepository
    {
        public void Criar(Tarefa tarefa);

        public void Salvar();

        public void Atualizar(Tarefa tarefa);

        public void Remover(int id);

        Tarefa BuscarPorId(int id);

        public IList<Tarefa> ListarTarefas();
    }
}
