
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

            context.Campeonatos.Remove(campeonatoExistente);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Campeonato> Modificar(Campeonato Campeonato)
        {
            var seleccionExistente = await context.Campeonatos.FindAsync(Campeonato.Id);
            if (seleccionExistente == null)
            {
                return null;
            }
            context.Entry(seleccionExistente).CurrentValues.SetValues(Campeonato);
            await context.SaveChangesAsync();
            return await context.Campeonatos.FindAsync(Campeonato.Id);
        }

        public async Task<Campeonato> Obtener(int Id)
        {
            return await context.Campeonatos.FindAsync(Id);
        }

        public async Task<IEnumerable<Campeonato>> ObtenerTodos()
        {
            return await context.Campeonatos.ToArrayAsync();
        }
    }
}
