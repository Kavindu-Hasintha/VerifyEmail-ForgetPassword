using System.ComponentModel.DataAnnotations;

namespace VerifyEmailAndForgetPassword.Models
{
    public class UserRegisterRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        // string.Empty = by default value will be string empty value
        [Required, MinLength(6), MaxLength(24)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string confirmPassword { get; set; } = string.Empty;
    }
}
