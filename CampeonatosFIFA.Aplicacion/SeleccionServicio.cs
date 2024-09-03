using CampeonatosFIFA.Core.Interfaces.Repositorios;
using CampeonatosFIFA.Core.Interfaces.Servicios;
using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Aplicacion
{
    public class SeleccionServicio : ISeleccionServicio
    {

        private readonly ISeleccionRepositorio repositorio;

        public SeleccionServicio(ISeleccionRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Task<Seleccion> Agregar(Seleccion Seleccion)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Seleccion>> Buscar(int IndiceDato, string Dato)
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
            return repositorio.Obtener(Id);
        }

        public Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return repositorio.ObtenerTodos();
        }
    }
}
