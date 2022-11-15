using Microsoft.AspNetCore.Mvc;
using PrimeiroTeste.Context;
using PrimeiroTeste.Models;
using PrimeiroTeste.Models.ViewModels;
using PrimeiroTeste.Repositorios.Interfaces;

namespace PrimeiroTeste.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly IProjetosRepositorio _context;

        public ProjetosController(IProjetosRepositorio context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projetos = _context.Projetos;

            var projetosViewModel = new ProjetoViewModel { Projetos = projetos };
            
            return View(projetosViewModel);
        }
    }
}
