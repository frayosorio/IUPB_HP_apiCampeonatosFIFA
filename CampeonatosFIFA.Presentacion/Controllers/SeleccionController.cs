using Microsoft.AspNetCore.Mvc;

namespace CampeonatosFIFA.Presentacion.Controllers
{
    public class SeleccionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
