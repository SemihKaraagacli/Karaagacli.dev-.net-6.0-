using CV.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CV.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();
        public IActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Admin p)
        {
            var bilgiler = db.admins.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Parola == p.Parola);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.KullaniciAdi)
                };
                //var useridentity = new ClaimsIdentity(claims, "Login");
                //ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                //await HttpContext.SignInAsync(principal);
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var autProperties = new AuthenticationProperties();
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),
                    autProperties);

                return RedirectToAction("PanelProfil", "PanelProfil");
            }
            return RedirectToAction("LoginPage", "Login");
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("LoginPage", "Login");
        }
    }
}
