using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JPBM.Models;

namespace JPBM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Conexao c = new Conexao(); 

            //for (var x = 1; x <= 150; x++)
            //{
            //    Rifa r = new Rifa();
            //    r.Nome = "";
            //    r.Numero = x;
            //    r.Pago = false;
            //    r.Vendido = false;
            //    c.Add(r);
            //}

            var listas = c.ListaOrdenada();
                var aux = 1;
                foreach (var lista in listas)
                {
                    ViewData["Lista" + aux] = lista;
                    aux++;
                }

                return View();
        }

        public async Task<IActionResult> indexx(RifaViewModel rifa)
        {
            return  View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
