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
            //PC CASA
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=NetGenerica; Integrated Security=True; Encrypt=False; MultipleActiveResultSets=True; TrustServerCertificate=True");

            //MAC
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=NetGenerica; Integrated Security=True; Encrypt=False; MultipleActiveResultSets=True;");

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}