using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{

    public class TakeAway
    {
        public int TakeAwayID { get; set; }

        [Required]
        [StringLength(100)]
        public string Request { get; set; }

        public string Description { get; set; }

    }
}
