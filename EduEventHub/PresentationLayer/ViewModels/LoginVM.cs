using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "User name or email is required.")]
        public string UserNameOrEmail { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; } = false;
    }
}
