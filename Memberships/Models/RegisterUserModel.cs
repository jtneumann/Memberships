using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    public class RegisterUserModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {1} characters long.",
            MinimumLength = 2)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {1} characters long. Have 1 non-letter, 1 digit, 1 uppercase('A'-'Z').", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public bool AcceptUserAgreement { get; set; }
    }
}