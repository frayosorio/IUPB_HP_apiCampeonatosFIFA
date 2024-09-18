using CampeonatosFIFA.Aplicacion;
using CampeonatosFIFA.Core.Interfaces.Repositorios;
using CampeonatosFIFA.Core.Interfaces.Servicios;
using CampeonatosFIFA.Infraestructura.Repositorio;
using CampeonatosFIFA.Infraestrutura.Persistencia.Contextos;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Presentacion.InyeccionDependencias
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarDependencias(this IServiceCollection servicios, IConfiguration configuration)
        {
            //agregar el DbContext
            servicios.AddDbContext<CampeonatosFIFAContext>(opciones =>
            {
                opciones.UseSqlServer(configuration.GetConnectionString("CampeonatosFIFA"));
            });

            //agregar los repositorios
            servicios.AddTransient<ISeleccionRepositorio, SeleccionRepositorio>();
            servicios.AddTransient<ICampeonatoRepositorio, CampeonatoRepositorio>();

            //agregar los servicios
            servicios.AddTransient<ISeleccionServicio, SeleccionServicio>();
            servicios.AddTransient<ICampeonatoServicio, CampeonatoServicio>();

            return servicios;
        }

    }
}
