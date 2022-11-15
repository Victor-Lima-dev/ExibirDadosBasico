using PrimeiroTeste.Models;
using System.Collections.Generic;

namespace PrimeiroTeste.Repositorios.Interfaces
{
    public interface IProjetosRepositorio
    {
        IEnumerable<Projeto> Projetos { get; }
    }
}
