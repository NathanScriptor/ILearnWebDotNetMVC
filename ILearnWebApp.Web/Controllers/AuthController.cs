using ILearnWebApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ILearnWebApp.Web.Controllers
{
    public class AuthController(UserManager<Account> userManager) : Controller
    {
        private readonly UserManager<Account> _userManager = userManager;

        public IActionResult Index()
        {
            return View();
        }
    }
}
