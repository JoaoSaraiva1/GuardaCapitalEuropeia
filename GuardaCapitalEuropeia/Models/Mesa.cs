using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class Mesa
    {
        public int MesaId { get; set; }

        [Required(ErrorMessage = "Por favor introduza o numero da mesa")]
        [StringLength(200)]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Por favor introduza o nome do restaurante")]
        public string Restaurante { get; set; }

        [Required(ErrorMessage = "Por favor introduza numero de lugares")]
        public string Lugares { get; set; }


    }
}
