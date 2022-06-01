using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger
            , SignInManager<IdentityUser> signInManager
            , UserManager<IdentityUser> UserManager)
        {
            _logger = logger;
            this.signInManager = signInManager;
            userManager = UserManager;
        }

        public async Task< IActionResult> Index()
        {
           IdentityUser identityUser = await userManager.FindByNameAsync("mostafathabetdesigner@gmail.com");
           ViewData["UserEmail"] = identityUser.Email;
            return View();
        }

        public IActionResult Privacy()
        {
            if (signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return RedirectToAction("AccessDenied", "Account", new { area = "Identity" });
            }
        }
        public IActionResult Test()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}