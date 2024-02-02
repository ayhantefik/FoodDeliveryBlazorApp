using FoodDelivery.Data;
using FoodDelivery.Global;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FoodDelivery.Areas.Identity.Data;
using FoodDelivery.Service;
using FoodDelivery.Utilities;

namespace FoodDelivery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string not found.");

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddTransient<EateryService>();
            builder.Services.AddTransient<ItemService>();
            builder.Services.AddSingleton<AddedItems>();
            builder.Services.AddDbContextFactory<AppDbContext>((DbContextOptionsBuilder options) => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            builder.Services.AddDbContext<AuthDbContext>((DbContextOptionsBuilder options) => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            builder.Services.AddTransient<IFileUploadService, ImageService>();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AuthDbContext>();


            builder.Services.AddAuthentication("Identity.Application").AddCookie(); // ADDED

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.Use(async (context, next) =>
            {
                // Configure Feature Policy headers
                context.Response.Headers.Add("Feature-Policy", "geolocation 'self'; midi 'self'; sync-xhr 'self'; microphone 'self'; camera 'self'; magnetometer 'self'; gyroscope 'self'; speaker 'self'; fullscreen *");

                await next();
            });

            app.UseRouting();

            app.UseAuthentication(); // ADDED
            app.UseAuthorization(); // ADDED

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
