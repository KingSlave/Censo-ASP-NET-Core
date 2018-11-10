using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using censo.Models;

namespace censo.Controllers
{
    public class HomeController : Controller
    {
        private static int cruz;
        public static int america;
        public static int toluca;
        public static int santos;

        [ViewData]
        public int opc1 { get; set; }
        [ViewData]
        public int opc2 { get; set; }
        [ViewData]
        public int opc3 { get; set; }
        [ViewData]
        public int opc4 { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CensoModel datos)
        {        
            contarCenso(datos.Opcion);
            return View("Index");
        }

        private void contarCenso(string opcion){

            switch (opcion)
            {
                case "cruz":
                    cruz++;
                    break;
                case "america":
                    america++;
                    break;
                case "toluca":
                    toluca++;
                    break;
                case "santos":
                    santos++;
                    break;
                default:
                    break;
            }
            opc1 = cruz;
            opc2 = america;
            opc3 = toluca;
            opc4 = santos;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
