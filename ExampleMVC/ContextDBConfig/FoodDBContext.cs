using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExampleMVC.Models;
using FoodApplication.ModelExpressionProvider;
using ExampleMVC.contextDBConfig;

namespace ExampleMVC.contextDBConfig
{
    public class FoodApplicationDB:IdentityDbContext<ApplicationUser>
    {
        public FoodApplicationDB(DbContextOptions<FoodApplicationDB> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}