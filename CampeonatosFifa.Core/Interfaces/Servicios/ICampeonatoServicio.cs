namespace CampeonatosFifa.Core.Interfaces.Servicios
{
    public interface ICampeonatoServicio
    {
        Task<Campeonato> Agregar(Campeonato Campeonato);

        Task<Campeonato> Modificar(Campeonato Campeonato);

        Task<bool> Eliminar(int Id);

        Task<Campeonato> Obtener(int Id);

        Task<IEnumerable<Campeonato>> ObtenerTodos();

        Task<IEnumerable<Campeonato>> Buscar(int Tipo, string Dato);

    }
}
