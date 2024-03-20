namespace CampeonatosFifa.Presentacion.Controllers
{

    [ApiController]
    [Route("api/campeonatos")]
    public class CampeonatoControlador : ControllerBase
    {
        private ICampeonatoServicio servicio;

        public CampeonatoControlador(ICampeonatoServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Campeonato>>> ObtenerTodos()
        {
            return Ok(await servicio.ObtenerTodos());
        }

        [HttpGet("obtener/{Id}")]
        public async Task<ActionResult<Campeonato>> Obtener(int Id)
        {
            return Ok(await servicio.Obtener(Id));
        }

        [HttpPost("agregar")]
        public async Task<ActionResult<Seleccion>> Agregar([FromBody] Campeonato Campeonato)
        {
            return Ok(await servicio.Agregar(Campeonato));
        }

        [HttpPut("modificar")]
        public async Task<ActionResult<Seleccion>> Modificar([FromBody] Campeonato Campeonato)
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
