using Microsoft.EntityFrameworkCore;
using FernandezCariaga.Entidades;
using Microsoft.Extensions.Logging;

namespace FernandezCariaga.Context
{
    public class Base : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public Base() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=NetGenerica; Integrated Security=True; Encrypt=False; MultipleActiveResultSets=True; TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}