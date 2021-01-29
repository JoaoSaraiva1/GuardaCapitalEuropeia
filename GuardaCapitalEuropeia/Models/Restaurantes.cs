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

        [Required(ErrorMessage = "Por favor introduza a sua descrição")]
        public string Description { get; set; }

        public int Contacto { get; set; }
        
        [Required(ErrorMessage = "Por favor introduza o seu numero de telemóvel")]
        [RegularExpression(("^[0-9]{9,9}$") , ErrorMessage = "Introduza o seu numero correto (9 Digitos)")]
         public string Contact { get; set; }

        [Required(ErrorMessage = "Por favor introduza o seu email")]
        [RegularExpression(@"(\w+(\.\w+)*@[a-zA-Z_]+?\.[a-zA-Z]{2,6})", ErrorMessage = "Por favor introduza o email correto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor introduza a sua localização")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Por favor introduza a sua Lotação")]
        public int LimitMax { get; set; }

    }
}
