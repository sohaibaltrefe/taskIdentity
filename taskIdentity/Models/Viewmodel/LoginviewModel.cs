using System.ComponentModel.DataAnnotations;

namespace taskIdentity.Models.Viewmodel
{
    public class LoginviewModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(45)]
        [Display(Name ="Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(45)]
        public string Password { get; set; }
        public bool  RememberMe { get; set; }
    }
}
