using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace NewsBootAspV.Data;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    [Display(Name = "FirstName")]
    [StringLength(100, MinimumLength = 3)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [Display(Name = "lastName")]
    [StringLength(100, MinimumLength = 3)]
    public string LastName { get; set; } = string.Empty;
}
