using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto_FourTask.Areas.Identity.Data;
using Projeto_FourTask.Models;
using Projeto_FourTask.Repositories;

namespace Projeto_FourTask.Controllers
{
    [Authorize]
    public class TarefaController : Controller
    {
        private Projeto_FourTaskContext _context;
        private ITarefaRepository _tarefaRepository;
        private IEquipeRepository _equipeRepository;

        public TarefaController(Projeto_FourTaskContext context, ITarefaRepository tarefaRepository, IEquipeRepository equipeRepository)
        {
            _context = context;
            _tarefaRepository = tarefaRepository;
            _equipeRepository = equipeRepository;
        }

        private void CarregarEquipes()
        {
            IList<Equipe> equipes = _equipeRepository.ListarEquipe();
            ViewBag.equipes = new SelectList(equipes, "EquipeId", "Nome");
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Criar()
        {
            CarregarEquipes();
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _tarefaRepository.Criar(tarefa);
                _tarefaRepository.Salvar();
                TempData["msg"] = "Tarefa criada com sucesso!";
                return RedirectToAction("Criar");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarEquipes();
            Tarefa tarefa = _tarefaRepository.BuscarPorId(id);
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefa)
        {
            _tarefaRepository.Atualizar(tarefa); //atualizar no banco
            _tarefaRepository.Salvar(); //salvar no banco
            TempData["msg"] = "Tarefa editada com sucesso!";
            return RedirectToAction("Editar");
        }

        [HttpPost]
        public IActionResult RemoverTarefa(int id)
        {
            _tarefaRepository.Remover(id);
            _tarefaRepository.Salvar();
            TempData["msgDelete"] = "Tarefa removida com sucesso!";
            return RedirectToAction("Index", "Equipe");
        }
    }
}
