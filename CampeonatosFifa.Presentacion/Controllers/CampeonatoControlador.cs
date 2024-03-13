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
        public async Task<ActionResult<IEnumerable<Seleccion>>> ObtenerTodos()
        {
            return Ok(await servicio.ObtenerTodos());
        }
    }
}
