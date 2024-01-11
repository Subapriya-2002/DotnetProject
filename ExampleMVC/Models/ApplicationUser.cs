using Microsoft.AspNetCore.Identity;
using ExampleMVC.Models;

namespace ExampleMVC.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
        public string? Address { get; set; }

    }
}