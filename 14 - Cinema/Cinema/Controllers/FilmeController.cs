using Cinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class FilmeController : Controller
    {

        private static List<Filme> _filmes = new List<Filme>();
        private static int _id;

        public IActionResult Index()
        {
            return View(_filmes);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Filme filme)
        {
            filme.Id = ++_id;
            _filmes.Add(filme);
            TempData["msg"] = "Veículo cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var filme = _filmes.Find(filme => filme.Id == id);
            return View(filme);
        }

        [HttpPost]
        public IActionResult Editar(Filme filme)
        {
            _filmes[_filmes.FindIndex(f => f.Id == filme.Id)] = filme;
            TempData["msg"] = "Filme editado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _filmes.RemoveAll(filme => filme.Id == id);
            TempData["msgDelete"] = "Filme removido com sucesso!";
            return RedirectToAction("index");   
        }

    }
}
