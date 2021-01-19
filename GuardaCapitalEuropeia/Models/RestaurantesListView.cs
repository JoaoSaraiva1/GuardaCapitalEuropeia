using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class RestaurantesListView
    {
        public IEnumerable<Restaurantes> Restaurantes { get; set; }
        public PaginationInfo Pagination { get; set; }

        public string SearchName { get; set; }
    }
}

