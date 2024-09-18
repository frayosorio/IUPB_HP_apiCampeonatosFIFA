using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Core.Interfaces.Servicios
{
    public interface ICampeonatoServicio
    {
        Task<IEnumerable<Campeonato>> ObtenerTodos();

        Task<Campeonato> Obtener(int Id);

        Task<IEnumerable<Campeonato>> Buscar(int IndiceDato, String Dato);

        Task<Campeonato> Agregar(Campeonato Campeonato);

        Task<Campeonato> Modificar(Campeonato Campeonato);

        Task<bool> Eliminar(int Id);
    }
}
