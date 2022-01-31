using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebamvc_1.Models
{
    public class TrabajadorContext:DbContext
    {
        public TrabajadorContext(DbContextOptions<TrabajadorContext> options) : base(options)
        {

        }

        public DbSet<Trabajador> Trabajador { get; set; }
    }
}
