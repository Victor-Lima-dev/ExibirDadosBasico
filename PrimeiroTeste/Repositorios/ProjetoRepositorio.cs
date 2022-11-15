using PrimeiroTeste.Context;
using PrimeiroTeste.Models;
using PrimeiroTeste.Repositorios.Interfaces;

namespace PrimeiroTeste.Repositorios
{
    public class ProjetoRepositorio : IProjetosRepositorio
    {
        private readonly AppDbContext _context;

        public ProjetoRepositorio(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Projeto> Projetos => _context.Projetos;
    }
}
