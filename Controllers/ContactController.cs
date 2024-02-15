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
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private ContactoContext contactocon;

        public ContactController(ContactoContext conn)
        {
            contactocon=conn;
        }

        public IActionResult Listar()
        {
            var lista = contactocon.ContactSet.ToList(); //.FromSqlRaw("sp_listar").toList();
            return View();
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