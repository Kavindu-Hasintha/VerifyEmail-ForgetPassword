using System.ComponentModel.DataAnnotations;

namespace VerifyEmailAndForgetPassword.Models
{
    public class ResetPasswordRequest
    {
        [Required]
        public string Token { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters"), MaxLength(24)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string confirmPassword { get; set; } = string.Empty;
    }
}
