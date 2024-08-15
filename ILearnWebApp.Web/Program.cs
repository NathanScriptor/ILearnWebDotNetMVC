using ILearnWebApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ILearnWebApp.Domain.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using ILearnWebApp.Domain.Interfaces.UnitOfWork;
using ILearnWebApp.Infrastructure.Repositories.UnitOfWork;
using ILearnWebApp.Application.IServices;
using ILearnWebApp.Application.Services;
using ILearnWebApp.Application.Mapper;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
        builder.Services.AddRazorPages();

        builder.Services.AddDbContext<ILearnDbContext>(options =>
        {
            options.UseSqlServer("DefaultConnection");
        });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            options.Cookie.Name = "YourAppCookieName";
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
            options.LoginPath = "/Views/Auth/Login";
            options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
            options.SlidingExpiration = true;
        });

        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IAccountService, AccountService>();
        builder.Services.AddScoped<ICourseRegistrationService, CourseRegistrationService>();
        builder.Services.AddScoped<ICourseService, CourseService>();
        builder.Services.AddScoped<IDiscountService, DiscountService>();
        builder.Services.AddScoped<ILecturerService, LecturerService>();
        builder.Services.AddScoped<IStudentService, StudentService>();
        builder.Services.AddScoped<IVideoService, VideoService>();

        builder.Services.AddAutoMapper(typeof(CourseProfile).Assembly);

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
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
