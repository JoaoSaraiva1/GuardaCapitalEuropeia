using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public interface RestaurantesRepository
    {
        public IEnumerable<Restaurantes> Restaurantes { get; }
    }
}
