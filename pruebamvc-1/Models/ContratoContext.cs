using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebamvc_1.Models
{
    public class ContratoContext : DbContext
    {
        public ContratoContext(DbContextOptions<ContratoContext> options)
            : base(options){
        
        }
        public DbSet<Contrato> Contrato{ get; set; }
    }
}
