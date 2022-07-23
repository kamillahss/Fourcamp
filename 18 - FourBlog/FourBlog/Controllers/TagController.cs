using FourBlog.Areas.Identity.Data;
using FourBlog.Models;
using FourBlog.Repositories;
using FourBlog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourBlog.Controllers
{
    [Authorize]
    public class TagController : Controller
    {

        private FourBlogContext _context;
        private ITagRepository _tagRepository;

        public TagController(FourBlogContext context, ITagRepository tagRepository)
        {
            _context = context;
            _tagRepository = tagRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /*ViewBag.tags = _tagRepository.ListarTags();*/
            TagViewModel tagViewModel = new TagViewModel()
            {
                Tags = _tagRepository.ListarTags()
            };
            return View(tagViewModel);
        }

        [HttpPost]
        public IActionResult Cadastrar(Tag tag)
        {
            if (ModelState.IsValid)
            {
                _tagRepository.Criar(tag);
                _tagRepository.Salvar();
                TempData["msg"] = "Tag cadastrada com sucesso!";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            Tag tag = _tagRepository.BuscarPorId(id);
            return View(tag);
        }

        [HttpPost]
        public IActionResult Editar(Tag tag)
        {
            _tagRepository.Atualizar(tag);
            _tagRepository.Salvar();
            TempData["msgEdit"] = "Tag editada com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _tagRepository.Remover(id);
            _tagRepository.Salvar();
            TempData["msgDelete"] = "Tag removida!";
            return RedirectToAction("Index");
        }
    }
}
