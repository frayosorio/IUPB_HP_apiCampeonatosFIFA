namespace CampeonatosFifa.Core.Interfaces.Servicios
{
    public interface ISeleccionServicio
    {
        Task<Seleccion> Agregar(Seleccion Seleccion);

        Task<Seleccion> Modificar(Seleccion Seleccion);

        Task<bool> Eliminar(int Id);

        Task<Seleccion> Obtener(int Id);

        Task<IEnumerable<Seleccion>> ObtenerTodos();

        Task<IEnumerable<Seleccion>> Buscar(int Tipo, string Dato);
    }
}
