using System.ComponentModel.DataAnnotations;

namespace CV_ASP.net.Models
{
    public class RegisterUserForm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les deux champs password doivent correspondre")]
        public string ConfirmPassword { get; set; }
    }
}
