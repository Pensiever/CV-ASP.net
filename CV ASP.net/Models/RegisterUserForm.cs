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
        [Compare("Password", ErrorMessage = "The two passwords must be the same")]
        public string ConfirmPassword { get; set; }
    }
}
