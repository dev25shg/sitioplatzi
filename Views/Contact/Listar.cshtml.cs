using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace sitioplatzi.Views.Contact
{
    public class Listar : PageModel
    {
        private readonly ILogger<Listar> _logger;

        public Listar(ILogger<Listar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}