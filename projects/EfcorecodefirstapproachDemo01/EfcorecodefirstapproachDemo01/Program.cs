using EfcorecodefirstapproachDemo01.Models;
using Microsoft.EntityFrameworkCore;

namespace EfcorecodefirstapproachDemo01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var ConString = builder.Configuration.GetConnectionString("cs1");
            builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(ConString));
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=EmployeeModels}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
