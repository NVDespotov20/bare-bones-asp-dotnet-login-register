namespace bare_bones_web_app.ViewModels;

using System.ComponentModel.DataAnnotations;
public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Phone]
    public string Telephone { get; set; }

    [Required]
    public int Score { get; set; }
}

