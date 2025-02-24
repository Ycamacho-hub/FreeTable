using FreeTable.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreeTable.Controllers
{
    public class RestaranteController : Controller
    {
        public IActionResult Index()
        {
            Restaurante r = new();

            return View();
        }
    }
}
