using FreeTable.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreeTable.Controllers
{
    public class RestauranteController : Controller
    {
        public IActionResult Index()
        {
            Restaurante r = new("A123454678", 
                "yosarca@gmail.com", 
                "churrasicparck", 
                "churros.park@gmail.com", 
                "Cll atras", 624527327, 
                "Churros en un parque", 150 );

            return View(r);
        }

        public IActionResult Privacy()
        {
            Restaurante r = new("A123454678",
                "yosarca@gmail.com",
                "Churrasic Parck",
                "churros.park@gmail.com",
                "Cll atras", 624527327,
                "Churros en un parque", 150);

            return View(r);
        }


    }
}
