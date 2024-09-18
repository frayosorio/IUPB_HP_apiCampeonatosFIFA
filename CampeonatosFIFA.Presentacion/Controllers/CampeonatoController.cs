using CampeonatosFIFA.Core.Interfaces.Servicios;
using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatosFIFA.Presentacion.Controllers
{
    [ApiController]
    [Route("api/campeonatos")]
    public class CampeonatoController : ControllerBase
    {
        private readonly ICampeonatoServicio servicio;

        public CampeonatoController(ICampeonatoServicio servicio)
        {
            this.servicio = servicio;
        }


        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Campeonato>>> ObtenerTodos()
        {
            return Ok(await servicio.ObtenerTodos());
        }

        [HttpGet("buscar/{IndiceDato}/{Dato}")]
        public async Task<ActionResult<IEnumerable<Campeonato>>> Buscar(int IndiceDato, string Dato)
        {
            return Ok(await servicio.Buscar(IndiceDato, Dato));
        }

        [HttpPost("agregar")]
        public async Task<ActionResult<Campeonato>> Agregar(Campeonato Campeonato)
        {
            return Ok(await servicio.Agregar(Campeonato));
        }

        [HttpPut("modificar")]
        public async Task<ActionResult<Campeonato>> Modificar(Campeonato Campeonato)
        {
            return Ok(await servicio.Modificar(Campeonato));
        }

        [HttpDelete("eliminar/{Id}")]
        public async Task<ActionResult<bool>> Eliminar(int Id)
        {
            return Ok(await servicio.Eliminar(Id));
        }
    }
}
