using System.Reflection;
using Microsoft.EntityFrameworkCore;
using CaliStrength.Models;

namespace CaliStrength.Data
{
    public class CaliStrengthDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<TipoEjercicio> TipoEjercicios { get; set; } = null!;
        public DbSet<Requisito> Requisitos { get; set; } = null!;
        public DbSet<Ejercicio> Ejercicios { get; set; } = null!;
        public DbSet<Dia> Dias { get; set; } = null!;
        public DbSet<Desempeno> Desempenos { get; set; } = null!;
        
        // Add DbSet properties for other entities

        public CaliStrengthDbContext(DbContextOptions<CaliStrengthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and other model configurations here
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
    }
    
}
