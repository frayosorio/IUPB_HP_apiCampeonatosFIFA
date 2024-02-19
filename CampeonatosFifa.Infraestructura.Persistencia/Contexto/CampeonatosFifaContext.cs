

namespace CampeonatosFifa.Infraestructura.Persistencia.Contexto
{
    public class CampeonatosFifaContext:DbContext
    {

        public CampeonatosFifaContext(DbContextOptions<CampeonatosFifaContext> options)
            : base(options)
        {

        }

        public DbSet<Seleccion> Selecciones { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Seleccion>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Campeonato>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Campeonato>()
                .HasOne(e => e.Seleccion)
                .WithMany()
                .HasForeignKey(e => e.IdSeleccion);

        }

    }
}
