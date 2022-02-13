using Identity.Data;
using Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;


        public AccountController(SignInManager<ApplicationIdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnURL)
        {
            

            ViewData["returnURL"] = returnURL;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequest loginRequest)
        {
            var result = await _signInManager.PasswordSignInAsync(loginRequest.Username, loginRequest.Password, loginRequest.RememberMe, false);
            if (result.Succeeded)
            {
               
                return LocalRedirect(loginRequest.ReturnURL);
            }
            TempData["Error"] = "Username or Password is not correct";
            return RedirectToAction("Login", "Account");
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            
            
            return Redirect("/");
        }
    }
}
