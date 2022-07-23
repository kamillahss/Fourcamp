using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_FourTask.Areas.Identity.Data;
using Projeto_FourTask.Models;
using Projeto_FourTask.Repositories;

namespace Projeto_FourTask.Controllers
{
    [Authorize]
    public class EquipeController : Controller
    {
        private Projeto_FourTaskContext _context;
        private IEquipeRepository _equipeRepository;
        private UserManager<Usuario> _userManager;
        private ITarefaRepository _tarefaRepository;
        private IUsuarioRepository _usuarioRepository;

        public EquipeController(Projeto_FourTaskContext context, IEquipeRepository equipeRepository, UserManager<Usuario> userManager, ITarefaRepository tarefaRepository, IUsuarioRepository usuarioRepository)
        {
            _context = context;
            _equipeRepository = equipeRepository;
            _userManager = userManager;
            _tarefaRepository = tarefaRepository;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Equipe equipe = _equipeRepository.BuscarEquipe(usuario => usuario.Id == _userManager.GetUserId(User));

            if(equipe == null)
            {
                return RedirectToAction("Listagem");
            }

            TempData["exibirEquipe"] = equipe.Nome;
            TempData["exibirDescricao"] = equipe.Descricao;
            TempData["exibirData"] = equipe.DataCriacao;
            TempData["exibirArea"] = equipe.AreaAtuacao;

            ViewBag.Tarefas = _tarefaRepository.ListarTarefas();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Equipe equipe)
        {
            if (ModelState.IsValid)
            {
                _equipeRepository.Cadastrar(equipe);
                _equipeRepository.Salvar();
                TempData["msg"] = "Cadastrado com sucesso!";
                return View("Cadastrar");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            //convertendo DbSet em List
            IList<Equipe> equipes = _equipeRepository.ListarEquipe();
            return View(equipes);
        }

        [HttpPost]
        public IActionResult AcessarEquipe(int id)
        {
            Usuario user = _context.Usuarios.Where(u => u.Id == _userManager.GetUserId(User)).FirstOrDefault();
            user.EquipeId = id;
            _usuarioRepository.AtualizarUsuario(user);
            _usuarioRepository.Salvar();
            TempData["msg"] = "Bem-vindo(a) a equipe!";
            return RedirectToAction("Listagem");
        }

        [HttpPost]
        public IActionResult AceitarTarefa(int id)
        {
            Tarefa tarefa = _context.Tarefas.Find(id);
            tarefa.UsuarioId = _userManager.GetUserId(User);
            _tarefaRepository.Atualizar(tarefa);
            _tarefaRepository.Salvar();
            TempData["msg"] = "Tarefa aceita com sucesso!";
            return RedirectToAction("Index");
        }

    }
}
