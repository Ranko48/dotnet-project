using System.ComponentModel.DataAnnotations;

namespace Identity.API.Models.Auth;

public class LoginInputModel
{
    [Required]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
    public string ReturnUrl { get; set; } = string.Empty;
}