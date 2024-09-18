using CampeonatosFIFA.Core.Interfaces.Repositorios;
using CampeonatosFIFA.Dominio.Entidades;
using CampeonatosFIFA.Infraestrutura.Persistencia.Contextos;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Infraestructura.Repositorio
{
    public class CampeonatoRepositorio : ICampeonatoRepositorio
    {

        private readonly CampeonatosFIFAContext context;

        public CampeonatoRepositorio(CampeonatosFIFAContext context)
        {
            this.context = context;
        }

        public async Task<Campeonato> Agregar(Campeonato Campeonato)
        {
            context.Campeonatos.Add(Campeonato);
            await context.SaveChangesAsync();
            return Campeonato;
        }

        public async Task<IEnumerable<Campeonato>> Buscar(int IndiceDato, string Dato)
        {
            return await context.Campeonatos
                                    .Where(item => (IndiceDato == 0 && item.Nombre.Contains(Dato)) ||
                                    (IndiceDato == 1 && item.Año==int.Parse(Dato)) ||
                                    (IndiceDato == 2 && item.Seleccion.Nombre.Contains(Dato)))
                                    .ToListAsync();
        }

        public async Task<bool> Eliminar(int Id)
        {
            var CampeonatoExistente = await context.Campeonatos.FindAsync(Id);
            if (CampeonatoExistente == null)
            {
                return false;
            }
            try
            {
                context.Campeonatos.Remove(CampeonatoExistente);
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
            var CampeonatoExistente = await context.Campeonatos.FindAsync(Campeonato.Id);
            if (CampeonatoExistente == null)
            {
                return null;
            }
            context.Entry(CampeonatoExistente).CurrentValues.SetValues(Campeonato);
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
