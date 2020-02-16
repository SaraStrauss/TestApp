using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Users
    {
        public int Id { get; set; }
        
        public string Email { get; set; }        
        public string Password { get; set; }

        [Display(Name = "Name")]
        public string DisplayName { get; set; }
        public string Mobile { get; set; }
        public DateTime LastLogin { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
    }

    public class RegistrationViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        //[StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string DisplayName { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Mobile no not valid")]
        public string Mobile { get; set; }       

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
