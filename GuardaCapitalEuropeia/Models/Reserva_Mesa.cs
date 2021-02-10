using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class Reserva_Mesa
    {
        public int Reserva_MesaId { get; set; }

        [StringLength(120)]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Por favor introduza a data de reserva")]
        public string Data_Reserva { get; set; }

        [Required(ErrorMessage = "Por favor introduza a hora da reserva")]
        public string Hora_Reserva { get; set; }

        [Required(ErrorMessage = "Por favor introduza o numero de pessoas")]
        public string Pessoas { get; set; }




    }
}

