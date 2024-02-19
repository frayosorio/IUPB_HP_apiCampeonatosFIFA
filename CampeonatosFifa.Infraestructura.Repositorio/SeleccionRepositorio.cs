


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

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
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

        public Task<Seleccion> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
