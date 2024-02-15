using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sitioplatzi.Models
{
    public class ContactoContext : DbContext
    {
        public ContactoContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Contacto> ContactSet {get; set;}
    }
}