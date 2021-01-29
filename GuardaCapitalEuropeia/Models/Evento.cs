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

        [Required]
        [StringLength(200)]
        
        public String Nome { get; set; }

        public String Localizacao { get; set; }

        public String Descricao { get; set; }

        public String Entrada { get; set; }

        public String Link { get; set; }
    }
}
