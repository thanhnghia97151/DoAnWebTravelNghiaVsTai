using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
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
            Member m = await provider.Member.GetMemberById(member.MemberId);
            if (member != null)
            {
                //if (!m.ConfirmedPhone)
                //{
                //    return Redirect($"/auth/confirmnumberphone/{member.MemberId}");
                //}
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
        public IActionResult GoogleSignIn()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }
        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
            var claims = result.Principal.Identities
                .FirstOrDefault().Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });
            Member obj = new Member();
            obj.Gender = null;
            obj.Password = Helper.RandomString(16);
            foreach (var claim in claims)
            {
                switch (claim.Type)
                {
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier":
                        obj.MemberID = claim.Value;
                        break;
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress":
                        obj.Email = obj.UserName = claim.Value;
                        break;
                }
            }
            ReponseLogin reponse = await provider.Member.LoginOAuth(obj);

            if (reponse != null)
            {

                List<Claim> list2 = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,reponse.MemberId),
                    new Claim(ClaimTypes.Name,reponse.Email),
                    new Claim(ClaimTypes.Email,reponse.Email),
                     //new Claim(ClaimTypes.PrimarySid,reponse.Token)
                };
                if (reponse.Roles != null)
                {
                    foreach (string role in reponse.Roles)
                    {
                        list2.Add(new Claim(ClaimTypes.Role, role));
                    }
                }
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(list2, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
                AuthenticationProperties properties = new AuthenticationProperties
                {
                    IsPersistent = false
                };
                await HttpContext.SignInAsync(principal, properties);
                return Redirect("/");
            }
            return Redirect("/auth/login");

        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ChangePassword(ChangePassword obj)
        {
            obj.Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            Member member = await provider.Member.GetMemberById(obj.Id);
            LoginModel model = new LoginModel { Urs = member.UserName, Pwd = obj.OldPassword };
            ReponseLogin checkMember = await provider.Member.Login(model);

            var t = Helper.Hash(obj.OldPassword);
            if (ModelState.IsValid)
            {
                if ( checkMember != null)
                {
                    if (obj.ConfirmPassword.Equals(obj.NewPassword))
                    {
                        if (await provider.Member.ChangePassword(obj) == 1)
                        {
                            return Redirect("/auth/logout");
                        }
                        

                    }
                }
            }
            ModelState.AddModelError("", "Change password Failded!");
            return View(obj); 
        }  
        
        // Cofirm Number phone
        public IActionResult ConfirmNumberPhone(string id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult ConfirmNumberPhone(ConfirmNumberPhone obj)
        {
            return View(obj);
        }
    }
}
