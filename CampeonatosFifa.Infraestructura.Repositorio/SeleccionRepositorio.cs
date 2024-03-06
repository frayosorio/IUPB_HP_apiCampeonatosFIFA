


using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace CampeonatosFifa.Infraestructura.Repositorio
{
    public class SeleccionRepositorio : ISeleccionRepositorio
    {
        private readonly CampeonatosFifaContext context;
        private readonly IMapper mapper;


        public SeleccionRepositorio(CampeonatosFifaContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Seleccion> Agregar(Seleccion Seleccion)
        {
            context.Selecciones.Add(Seleccion);
            await context.SaveChangesAsync();
            return Seleccion;
        }

        public async Task<bool> Eliminar(int Id)
        {
            var seleccionExistente = await context.Selecciones.FindAsync(Id);
            if (seleccionExistente == null)
            {
                return false;
            }

            context.Selecciones.Remove(seleccionExistente);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Seleccion> Modificar(Seleccion Seleccion)
        {
            var seleccionExistente = await context.Selecciones.FindAsync(Seleccion.Id);
            if(seleccionExistente == null)
            {
                return null;
            }

            mapper.Map(Seleccion, seleccionExistente);
            await context.SaveChangesAsync();

            return seleccionExistente;
        }

        public async Task<Seleccion> Obtener(int Id)
        {
            return await context.Selecciones.FindAsync(Id);
        }

        public async Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return await context.Selecciones.ToArrayAsync();
        }
    }
}
