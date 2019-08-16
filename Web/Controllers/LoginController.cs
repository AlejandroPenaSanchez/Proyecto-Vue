using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Web.Models;
using System.Diagnostics;
using Web.ViewModels;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        // private readonly SignInManager<IdentityUser> signInManager;

        // public LoginController(SignInManager<IdentityUser> signInManager)
        // {
        //     this.signInManager = signInManager;
        // }

        public IActionResult Index()
        {
            return View();
        }

        // [HttpPost]
        // public async Task<IActionResult> Logout()
        // {
        //     await signInManager.SignOutAsync();
        //     return RedirectToAction("index", "Login");
        // }

        // [HttpPost]
        // public async Task<IActionResult> Login(LoginViewModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var result = await signInManager.PasswordSignInAsync(
        //             model.User, model.Password, model.RememberMe, false);

        //         if (result.Succeeded)
        //         {
        //             return RedirectToAction("index", "Home");
        //         }

        //         ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
        //     }

        //     return View(model);
        // }

    }
}