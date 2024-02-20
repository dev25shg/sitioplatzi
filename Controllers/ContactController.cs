using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sitioplatzi.Models;

namespace sitioplatzi.Controllers
{
    //[Route("[controller]")]
    public class ContactController : Controller
    {
        //Crear carpeta Datos donde se consuman las consulta de EF private ContactoContext contactocon; 
        private readonly ILogger<HomeController> _logger;
        //private ContactoContext conn;

        public ContactController(ILogger<HomeController> logger)
        {
            _logger=logger;
        }

        public IActionResult Listar()
        {
            //var lista = contactocon.ContactSet.ToList(); //.FromSqlRaw("sp_listar").toList();
            return View();
        }

        public IActionResult Guardar() {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(Contacto oConact) {
            return RedirectToAction("Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

     /*   ~ContactController() {
            contactocon.Dispose();
        } */
    }
}