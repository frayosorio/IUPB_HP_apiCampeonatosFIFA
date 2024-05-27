
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFifa.Infraestructura.Repositorio
{
    public class CampeonatoRepositorio : ICampeonatoRepositorio
    {
        private CampeonatosFifaContext context;


        public CampeonatoRepositorio(CampeonatosFifaContext context)
        {
            this.context = context;
        }

        public async Task<Campeonato> Agregar(Campeonato Campeonato)
        {
            context.Campeonatos.Add(Campeonato);
            await context.SaveChangesAsync();
            return Campeonato;
        }

        public async Task<bool> Eliminar(int Id)
        {
            var campeonatoExistente = await context.Campeonatos.FindAsync(Id);
            if (campeonatoExistente == null)
            {
                return false;
            }
            try
            {
                context.Campeonatos.Remove(campeonatoExistente);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Campeonato> Modificar(Campeonato Campeonato)
        {
            var campeonatoExistente = await context.Campeonatos.FindAsync(Campeonato.Id);
            if (campeonatoExistente == null)
            {
                return null;
            }
            context.Entry(campeonatoExistente).CurrentValues.SetValues(Campeonato);
            await context.SaveChangesAsync();
            return await context.Campeonatos.FindAsync(Campeonato.Id);
        }

        public async Task<Campeonato> Obtener(int Id)
        {
            return await context.Campeonatos.FindAsync(Id);
        }

        public async Task<IEnumerable<Campeonato>> ObtenerTodos()
        {
            return await context.Campeonatos.
                                    Include(e => e.Seleccion)
                                    .ToListAsync();
        }

        public async Task<IEnumerable<Campeonato>> Buscar(int Tipo, string Dato)
        {
            return await context.Campeonatos
                                .Where(item => (Tipo == 0 && item.Nombre.Contains(Dato)) ||
                                                (Tipo == 1 && item.Año.ToString().Contains(Dato))
                                )
                                .Include(e => e.Seleccion)
                                .ToListAsync();
        }
    }
}
