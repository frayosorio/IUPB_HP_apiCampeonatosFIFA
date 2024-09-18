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

        [HttpGet("buscar/{IndiceDato}/{Dato}")]
        public async Task<ActionResult<IEnumerable<Seleccion>>> Buscar(int IndiceDato, string Dato)
        {
            return Ok(await servicio.Buscar(IndiceDato, Dato));
        }

        [HttpPost("agregar")]
        public async Task<ActionResult<Seleccion>> Agregar(Seleccion Seleccion)
        {
            return Ok(await servicio.Agregar(Seleccion));
        }

        [HttpPut("modificar")]
        public async Task<ActionResult<Seleccion>> Modificar(Seleccion Seleccion)
        {
            return Ok(await servicio.Modificar(Seleccion));
        }

        [HttpDelete("eliminar/{Id}")]
        public async Task<ActionResult<bool>> Eliminar(int Id)
        {
            return Ok(await servicio.Eliminar(Id));
        }
    }
}
