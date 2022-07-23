using loginIdentity.Areas.Identity.Data;
using loginIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace loginIdentity.Controllers
{
    [Authorize] //Só entra na página se estiver logado
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjetoBancoContext _context;
        private UserManager<Cliente> _userManage; // pegar o Id do usuário logado

        public HomeController(ILogger<HomeController> logger, ProjetoBancoContext context, UserManager<Cliente> userManager)
        {
            _logger = logger;
            _context = context;
            _userManage = userManager; 
        }

        
        public IActionResult Index()
        {
            Cliente clienteLogado = _context.Clientes.Find(_userManage.GetUserId(User));
            return View(clienteLogado);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}