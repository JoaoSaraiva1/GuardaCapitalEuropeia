using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class Prato{
        public int PratoID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name{ get; set; }

        
        public string Description { get; set; }

        public string Preco { get; set; }

        public string Alergénicos { get; set; }

        public string RestauranteId { get; set; }

    }
}
