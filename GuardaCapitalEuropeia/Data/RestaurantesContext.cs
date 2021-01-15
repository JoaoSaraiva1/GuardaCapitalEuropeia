using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuardaCapitalEuropeia.Models;

namespace GuardaCapitalEuropeia.Data
{
    public class RestaurantesContext : DbContext
    {
        public RestaurantesContext (DbContextOptions<RestaurantesContext> options)
            : base(options)
        {
        }

        public DbSet<GuardaCapitalEuropeia.Models.Restaurantes> Restaurantes { get; set; }

        public DbSet<GuardaCapitalEuropeia.Models.TakeAway> TakeAway{ get; set; }
    }
      
}
