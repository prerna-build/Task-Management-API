using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 character")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "password mjust be atleast 6 letters")]
        public string Password { get; set; } = string.Empty;
    }
}
