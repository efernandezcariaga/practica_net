using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using FernandezCariaga.Entidades;

namespace FernandezCariaga.Contexto
{
    public class EvaluacionUsuarios : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public EvaluacionUsuarios()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=EvaluacionUsuarios; Integrated Security=True; Encrypt=False; MultipleActiveResultSets=True; TrustServerCertificate=True");

        }
    }
}