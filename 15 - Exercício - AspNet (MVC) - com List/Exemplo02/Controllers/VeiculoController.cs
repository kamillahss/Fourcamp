using Exemplo02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo02.Controllers
{

    public class VeiculoController : Controller
    {
        //vai servir como "banco de dados interno"
        private static List<Veiculo> _veiculos = new List<Veiculo>();
        private static int _id;

        public IActionResult Index()
        {
            return View(_veiculos);
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo)
        {
            veiculo.Id = ++ _id;
            _veiculos.Add(veiculo);
            TempData["msg"] = "Veículo cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var veiculo = _veiculos.Find(veiculo => veiculo.Id == id);
            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Veiculo veiculo)
        {
            _veiculos[_veiculos.FindIndex(v => v.Id == veiculo.Id)] = veiculo;
            TempData["msg"] = "Veiculo editado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
