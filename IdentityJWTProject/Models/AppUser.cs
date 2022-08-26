using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityJWTProject.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(50)]
        public string? MobileType { get; set; }
    }
}
