using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels 
{    
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string User { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}