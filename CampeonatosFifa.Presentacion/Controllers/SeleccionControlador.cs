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

    }
}
