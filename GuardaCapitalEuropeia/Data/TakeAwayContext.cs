using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuardaCapitalEuropeia.Models;

namespace GuardaCapitalEuropeia.Data
{
    public class TakeAwayContext : DbContext
    {
        public TakeAwayContext (DbContextOptions<TakeAwayContext> options)
            : base(options)
        {
        }

        public DbSet<GuardaCapitalEuropeia.Models.TakeAway> TakeAway { get; set; }
    }
}
