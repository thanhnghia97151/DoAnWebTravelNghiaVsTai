using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Controllers
{
    public class AuthController : Controller
    {
        SiteProvider provider;
        public AuthController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        //Register: /auth/register
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Member obj)
        {
            if (ModelState.IsValid)
            {
               
                var result = await provider.Member.Add(obj);
                return Redirect("/auth/login");
            }
            return View(obj);
        }
        //Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel obj, string returnUrl)
        {
            ReponseLogin member = await provider.Member.Login(obj);
            if (member != null)
            {
                //Code
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,member.MemberId),
                    new Claim(ClaimTypes.Email,member.Email),
                    new Claim(ClaimTypes.Name,obj.Urs),
                    //new Claim(ClaimTypes.PrimarySid,member.Token)//Chuyền thử vào PrimarySid đề test
                };
                if (member.Roles != null)
                {
                    foreach (string role in member.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                }
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                AuthenticationProperties properties = new AuthenticationProperties
                {
                    IsPersistent = obj.Rem
                };
                await HttpContext.SignInAsync(principal, properties);
                if (string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect("/");
                }
                else
                {
                    return Redirect(returnUrl);
                }

            }
            ModelState.AddModelError("", "Login Fail");
            return View();
        }
       
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/auth/login");
        }
    }
}
