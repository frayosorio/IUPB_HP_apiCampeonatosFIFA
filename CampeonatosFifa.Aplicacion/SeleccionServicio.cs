namespace CampeonatosFifa.Aplicacion
{
    public class SeleccionServicio : ISeleccionServicio
    {

        ISeleccionRepositorio repositorio;

        public SeleccionServicio(ISeleccionRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Task<Seleccion> Agregar(Seleccion Seleccion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Seleccion> Modificar(Seleccion Seleccion)
        {
            throw new NotImplementedException();
        }

        public Task<Seleccion> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return repositorio.ObtenerTodos();
        }
    }
}
