using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ExampleMVC.Models;
using ExampleMVC.contextDBConfig;
using ExampleMVC.Repository;
using ExampleMVC.Filters;

var builder = WebApplication.CreateBuilder(args);
        var dbconnection = builder.Configuration.GetConnectionString("dbConnection");
        
        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddControllers(Options =>
        {
        Options.Filters.Add(new Filter());
        });

        builder.Services.AddDbContext<FoodApplicationDB>(options =>
        options.UseSqlServer(dbconnection));

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
           .AddEntityFrameworkStores<FoodApplicationDB>();

        builder.Services.AddTransient<IData, Data>();   

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
  