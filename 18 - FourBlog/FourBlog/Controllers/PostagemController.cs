using FourBlog.Areas.Identity.Data;
using FourBlog.Models;
using FourBlog.Repositories;
using FourBlog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FourBlog.Controllers
{
    public class PostagemController : Controller
    {
        private FourBlogContext _context;
        private UserManager<Usuario> _userManager;
        private ITagRepository _tagRepository;
        private IPostagemRepository _postagemRepository;

        public PostagemController(FourBlogContext context, UserManager<Usuario> userManager, ITagRepository tagRepository, IPostagemRepository postagemRepository)
        {
            _context = context;
            _userManager = userManager;
            _tagRepository = tagRepository;
            _postagemRepository = postagemRepository;
        }

        public IActionResult Index(string tagBusca)
        {
            List<Postagem> postagens = _context.Postagens.Where(t => t.Tag.Nome.Contains(tagBusca) || tagBusca == null).Include(t => t.Usuario).Include(t => t.Tag).ToList();
            return View(postagens);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            List<Tag> tags = _context.Tags.ToList();
            /*ViewBag.tags = new SelectList(tags, "TagId", "Nome");*/
            PostCadastrarViewModel model = new PostCadastrarViewModel()
            {
                TagsSelect = new SelectList(tags, "TagId", "Nome")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Cadastrar(Postagem postagem)
        {
            if (ModelState.IsValid)
            {
                postagem.UsuarioId = _userManager.GetUserId(User);
                _postagemRepository.Cadastrar(postagem);
                _postagemRepository.Salvar();
                TempData["msg"] = "Cadastrada com sucesso!";
                return RedirectToAction("Cadastrar");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            /*ViewBag.comentarios = _context.Comentarios.Include(c => c.Usuario).Where(c => c.PostagemId == id).ToList();*/
            PostVisualizarViewModel viewModel = new PostVisualizarViewModel()
            {
                Post = _context.Postagens.Include(p => p.Usuario).Include(p => p.Tag).Where(p => p.PostagemId == id).FirstOrDefault(),
                Comentarios = _context.Comentarios.Include(c => c.Usuario).Where(c => c.PostagemId == id).ToList()
            };
            /*Postagem postagem = _context.Postagens.Include(p => p.Usuario).Include(p => p.Tag).Where(p => p.PostagemId == id).FirstOrDefault();*/
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CriarComentario(Comentario comentario)
        {
            comentario.UsuarioId = _userManager.GetUserId(User);
            _postagemRepository.CriarComentario(comentario);
            _postagemRepository.SalvarComentario();
            TempData["msg"] = "Comentário realizado com sucesso!";
            return RedirectToAction("Visualizar", new { id = comentario.PostagemId });
        }
    }
}
