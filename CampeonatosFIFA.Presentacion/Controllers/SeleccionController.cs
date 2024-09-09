using CampeonatosFIFA.Core.Interfaces.Repositorios;
using CampeonatosFIFA.Core.Interfaces.Servicios;
using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatosFIFA.Presentacion.Controllers
{
    [ApiController]
    [Route("api/selecciones")]
    public class SeleccionController : ControllerBase
    {
        private readonly ISeleccionServicio servicio;

          public SeleccionController(ISeleccionServicio servicio)
        {
            this.servicio = servicio;
        }


        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Seleccion>>> ObtenerTodos()
        {
            return Ok(await servicio.ObtenerTodos());
        }


    }
}
