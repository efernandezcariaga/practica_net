using Microsoft.EntityFrameworkCore;
using FernandezCariaga.Entidades;

namespace FernandezCariaga.Contexto
{
    public class Base : DbContext
    {
        public DbSet<Docente> Docentes { get; set; }
        public Base() 
        { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=NetGenerica; Integrated Security=True; Encrypt=False; MultipleActiveResultSets=True; TrustServerCertificate=True");

            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; User Id=net; Password = net; Database=NetGenerica; Integrated Security=True; Encrypt=False; MultipleActiveResultSets=True; TrustServerCertificate=True");
            
        }
    }
}