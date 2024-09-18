using CampeonatosFIFA.Core.Interfaces.Repositorios;
using CampeonatosFIFA.Core.Interfaces.Servicios;
using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Aplicacion
{
    public class CampeonatoServicio : ICampeonatoServicio
    {
        private readonly ICampeonatoRepositorio repositorio;

        public CampeonatoServicio(ICampeonatoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Task<Campeonato> Agregar(Campeonato Campeonato)
        {
            return repositorio.Agregar(Campeonato);
        }

        public Task<IEnumerable<Campeonato>> Buscar(int IndiceDato, string Dato)
        {
            return repositorio.Buscar(IndiceDato, Dato);
        }

        public Task<bool> Eliminar(int Id)
        {
            return repositorio.Eliminar(Id);
        }

        public Task<Campeonato> Modificar(Campeonato Campeonato)
        {
            return repositorio.Modificar(Campeonato);
        }

        public Task<Campeonato> Obtener(int Id)
        {
            return repositorio.Obtener(Id);
        }

        public Task<IEnumerable<Campeonato>> ObtenerTodos()
        {
            return repositorio.ObtenerTodos();
        }
    }
}
