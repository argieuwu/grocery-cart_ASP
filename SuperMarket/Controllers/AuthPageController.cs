using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace GeoceriCart.Controllers
{
    public class AuthPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //login page
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Validate username and password (this is just a placeholder for actual authentication logic)
            if (username == "testuser" && password == "password") // Replace this with actual authentication
            {
                // Redirect to the homepage on successful login
                return RedirectToAction("Homepage", "Home");
            }
            else
            {
                // Show an error message or redirect to the login page with an error
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
