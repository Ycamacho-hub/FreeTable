using Microsoft.AspNetCore.Mvc;

namespace FreeTable.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult Restaurante()
        {
            return View();
        }

    }
}
