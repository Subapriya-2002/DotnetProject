using ExampleMVC.Models;
using System.Security.Claims;

namespace ExampleMVC.Repository
{
    public interface IData
    {
        Task<ApplicationUser> GetUser(ClaimsPrincipal claims);
    }
}