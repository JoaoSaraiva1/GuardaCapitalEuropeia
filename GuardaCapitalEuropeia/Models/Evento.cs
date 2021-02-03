using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class Evento
    {   
        public int EventoId { get; set; }

        [Required(ErrorMessage ="Por favor introduza o nome do Evento")]
        [StringLength(200)]
        
        public String Nome { get; set; }

        [Required(ErrorMessage = "Por favor introduza o local do Evento")]
        public String Localizacao { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma descrição do Evento")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "Por favor introduza o valor da entrada no Evento")]
        public String Entrada { get; set; }

        [Required(ErrorMessage = "Por favor introduza o link com mais informação do Evento")]
        public String Link { get; set; }
    }
}
