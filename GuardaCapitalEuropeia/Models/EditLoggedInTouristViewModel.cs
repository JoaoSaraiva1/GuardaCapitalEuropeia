﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class EditLoggedInTouristViewModel
    {
        [Required]
        [StringLength(128)]
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
