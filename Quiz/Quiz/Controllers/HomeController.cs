using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }




        /// <summary>
        /// invoca a View inicial do programa
        /// </summary>
        /// <returns>a view</returns>
        public IActionResult Index()
        {
            ViewBag.Resposta = "";
            return View();
        }



        /// <summary>
        /// Devolve os dados para a View
        /// </summary>
        /// <param name="Nome">nome do utilizador</param>
        /// <param name="Anos">idade do utilizador</param>
        /// <returns> a view</returns>
        [HttpPost] // anuncia que este método vai reagir ao verbo POST do HTTP
        public IActionResult Index(string Nome, int Anos)
        {
            // preparar os dados para irem para a View

            ViewBag.Resposta = "O utilizador chama-se " + Nome + ", e tem " + Anos + " anos.";

            return View();
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
