using Microsoft.AspNetCore.Identity;

namespace bare_bones_web_app.Models;

public class ApplicationUser : IdentityUser
{
    public string Telephone { get; set; } = "";
    public int Score { get; set; } = 0;

}
