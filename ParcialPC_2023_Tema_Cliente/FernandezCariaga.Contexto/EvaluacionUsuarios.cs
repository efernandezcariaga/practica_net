using FernandezCariaga.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FernandezCariaga.Contexto
{
    public class EvaluacionUsuarios : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public EvaluacionUsuarios()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = @"(localdb)\MSSQLLocalDB";

            var databaseName = "parcial";

            var connectionString = @$"
                    Server={server};
                    Initial Catalog={databaseName};
                    TrustServerCertificate=True;
                    Integrated Security = True;";

            optionsBuilder.UseSqlServer(connectionString);

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}