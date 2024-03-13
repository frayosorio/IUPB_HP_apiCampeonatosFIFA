using CampeonatosFifa.Core.Interfaces.Servicios;

namespace CampeonatosFifa.Presentacion.DI
{
    public static class InyeccionDependencias
    {

        public static IServiceCollection AgregarDependencias(this IServiceCollection servicios, IConfiguration configuracion)
        {

            //Agregar el DBContext
            servicios.AddDbContext<CampeonatosFifaContext>(opcionesConstruccion =>
            {
                opcionesConstruccion.UseSqlServer(configuracion.GetConnectionString("CampeonatosFIFA"));
            });

            //Agregar los repositorios
            servicios.AddTransient<ISeleccionRepositorio, SeleccionRepositorio>();
            servicios.AddTransient<ICampeonatoRepositorio, CampeonatoRepositorio>();

            //Agregar los servicios
            servicios.AddTransient<ISeleccionServicio, SeleccionServicio>();
            servicios.AddTransient<ICampeonatoServicio, CampeonatoServicio>();


            return servicios;
        }

    }
}
