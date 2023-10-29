using Microsoft.AspNetCore.Mvc;

namespace ProyNeptunoQuery.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
