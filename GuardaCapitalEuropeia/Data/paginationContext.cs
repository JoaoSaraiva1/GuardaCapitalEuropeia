using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuardaCapitalEuropeia.Models;

namespace GuardaCapitalEuropeia.Data
{
    public class paginationContext : DbContext
    {
        public paginationContext (DbContextOptions<paginationContext> options)
            : base(options)
        {
        }

        public DbSet<GuardaCapitalEuropeia.Models.Restaurantes> Restaurantes { get; set; }
    }
}
