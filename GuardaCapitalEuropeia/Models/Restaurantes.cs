using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class Restaurantes
    {
        public int RestaurantesId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Contacto { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public string Location { get; set; }

        public int LimitMax { get; set; }

    }
}
