namespace CampeonatosFifa.Presentacion.Controllers
{
    [ApiController]
    [Route("api/selecciones")]
    public class SeleccionControlador : ControllerBase
    {
        private ISeleccionServicio servicio;


        public SeleccionControlador(ISeleccionServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Seleccion>>> ObtenerTodos()
        {
            return Ok(await servicio.ObtenerTodos());
        }

        [HttpGet("obtener/{Id}")]
        public async Task<ActionResult<Seleccion>> Obtener(int Id)
        {
            return Ok(await servicio.Obtener(Id));
        }

        [HttpPost("agregar")]
        public async Task<ActionResult<Seleccion>> Agregar([FromBody] Seleccion Seleccion)
        {
            return Ok(await servicio.Agregar(Seleccion));
        }

        [HttpPut("modificar")]
        public async Task<ActionResult<Seleccion>> Modificar([FromBody] Seleccion Seleccion)
        {
            return Ok(await servicio.Modificar(Seleccion));
        }

    }
}
