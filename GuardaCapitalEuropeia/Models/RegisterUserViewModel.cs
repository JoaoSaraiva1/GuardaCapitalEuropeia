using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardaCapitalEuropeia.Models
{
    public class RegisterUserViewModel
    {
        [Required]
        [StringLength(168)]
        public string Nome { get; set; }

        [Required]
        [StringLength(500)]
        public string Pais { get; set; }

        [Required]
        [StringLength(120)]
        public string Nascimento { get; set; }

        [Required]
        [StringLength(256)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "As passwords não coincidem")]
        public string ConfirmPassword { get; set; }
    }
}
