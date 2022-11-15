using Microsoft.EntityFrameworkCore;
using PrimeiroTeste.Models;

namespace PrimeiroTeste.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}
