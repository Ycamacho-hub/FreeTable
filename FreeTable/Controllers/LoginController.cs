using Microsoft.AspNetCore.Mvc;

namespace FreeTable.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
