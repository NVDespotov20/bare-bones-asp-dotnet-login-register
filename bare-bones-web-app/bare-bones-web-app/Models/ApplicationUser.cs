using Microsoft.AspNetCore.Identity;

namespace bare_bones_web_app.Models;

// You can call this class anything as long as it inherits from IdentityUser
public class ApplicationUser : IdentityUser
{
    // There is no need for an ID here as IdentityUser already provides one
    // For any relationships between models the userId MUST be of type string.
    // The IdentityUser class already contains a UserName, Email, PasswordHash and more properties
    public string Telephone { get; set; } = "";
    public int Score { get; set; } = 0;

}
