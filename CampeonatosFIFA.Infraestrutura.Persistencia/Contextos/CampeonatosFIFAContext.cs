
using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Infraestrutura.Persistencia.Contextos
{
    public class CampeonatosFIFAContext : DbContext
    {
        public CampeonatosFIFAContext(DbContextOptions<CampeonatosFIFAContext> options) : base(options)
        {
        }

        public DbSet<Seleccion> Selecciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seleccion>(seleccion =>
            {
                seleccion.HasKey(s => s.Id);
                seleccion.HasIndex(s => s.Nombre).IsUnique();
            });

            modelBuilder.Entity<Campeonato>(campeonato =>
            {
                campeonato.HasKey(s => s.Id);
                campeonato.HasIndex(s => s.Nombre).IsUnique();
            });

            modelBuilder.Entity<Campeonato>()
                .HasOne(c => c.Seleccion)
                .WithMany()
                .HasForeignKey(c => c.IdSeleccion);
        }

    }
}
