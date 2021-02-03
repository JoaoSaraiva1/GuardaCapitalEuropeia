using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class Prato{
        public int PratoID { get; set; }

        [Required(ErrorMessage ="Por favor introduza o nome do Prato")]
        [StringLength(200)]
        public string Name{ get; set; }

        [Required(ErrorMessage = "Por favor introduza uma descrição do Prato")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Por favor introduza o preço do Prato")]
        public string Preco { get; set; }

        [Required(ErrorMessage = "Por favor introduza ingredientes passiveis de alergias")]
        public string Alergénicos { get; set; }

        [Required(ErrorMessage = "Por favor introduza o Nome do Seu Restaurante")]
        public string RestauranteId { get; set; }

    }
}
