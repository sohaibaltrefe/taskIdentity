using System.ComponentModel.DataAnnotations;

namespace taskIdentity.Models.Viewmodel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(45)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(25)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(25)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
        
    }
}
