using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Core.Interfaces.Repositorios
{
    public interface ISeleccionRepositorio
    {
        Task<IEnumerable<Seleccion>> ObtenerTodos();

        Task<Seleccion> Obtener(int Id);

        Task<IEnumerable<Seleccion>> Buscar(int IndiceDato, String Dato);

        Task<Seleccion> Agregar(Seleccion Seleccion);

        Task<Seleccion> Modificar(Seleccion Seleccion);

        Task<bool> Eliminar(int Id);
    }
}
