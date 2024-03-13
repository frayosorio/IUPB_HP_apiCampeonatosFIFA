namespace CampeonatosFifa.Aplicacion
{
    public class SeleccionServicio : ISeleccionServicio
    {

        ISeleccionRepositorio repositorio;

        public SeleccionServicio(ISeleccionRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Seleccion> Agregar(Seleccion Seleccion)
        {
            return await repositorio.Agregar(Seleccion);
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Seleccion> Modificar(Seleccion Seleccion)
        {
            return await repositorio.Modificar(Seleccion);
        }

        public async Task<Seleccion> Obtener(int Id)
        {
            return await repositorio.Obtener(Id);
        }

        public async Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return await repositorio.ObtenerTodos();
        }
    }
}
