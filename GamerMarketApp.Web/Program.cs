using GamerMarketApp.Data;
using Microsoft.EntityFrameworkCore;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Services.Data;
using GamerMarketApp.Data.Repository;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace GamerMarketApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<GamerMarketDbContext>(options =>
               options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<GamerMarketDbContext>();

            builder.Services.AddScoped(typeof(IGenericRepository<>),
                typeof(GenericRepository<>));
            builder.Services.AddScoped<IGameRepository, GameRepository>();
            builder.Services.AddScoped<IItemRepository, ItemRepository>();

            builder.Services.AddScoped<IGameService, GameService>();
            builder.Services.AddScoped<IItemService, ItemService>();
            builder.Services.AddScoped<IWatchlistService, WatchlistService>();

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
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
            app.MapRazorPages();

            app.Run();
        }
    }
}
