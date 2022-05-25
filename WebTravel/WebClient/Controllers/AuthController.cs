using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebClient.Extentions;
using WebClient.Models;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Controllers
{
    public class AuthController : Controller
    {
        SiteProvider provider;
        private readonly IForgetPasswordRepository _forgetPasswordRepository;

        public AuthController(IConfiguration configuration,
            IForgetPasswordRepository forgetPasswordRepository)
        {
            provider = new SiteProvider(configuration);
            _forgetPasswordRepository = forgetPasswordRepository;
        }

        //Register: /auth/register
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Member obj, string confirmPassword)
        {
            if (ModelState.IsValid)
            {
                if (PasswordNews.CheckPassword(obj.Password, confirmPassword) == "1")
                {
                    if (LoginInformation.CheckBrithday(obj.Birthday) == "1")
                    {
                        try
                        {
                            var result = await provider.Member.Add(obj);
                            return Redirect("/auth/login");
                        }
                        catch (System.Exception)
                        {

                            ModelState.AddModelError("", "Lỗi hệ thống thử lại sau");
                        }
                    }
                    ViewBag.ErrorBrithday = LoginInformation.CheckBrithday(obj.Birthday);
                }
                ViewBag.ErrorPassword = PasswordNews.CheckPassword(obj.Password, confirmPassword);
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
            if (ModelState.IsValid) 
            {
                if (LoginInformation.CheckLogin(obj) == "1")
                {
                    ReponseLogin member = await provider.Member.Login(obj);
                    if (member != null)
                    {
                        Member m = await provider.Member.GetMemberById(member.MemberId);
                        if (member != null)
                        {
                            //if (!m.ConfirmedPhone)
                            //{
                            //    return Redirect($"/auth/confirmnumberphone/{member.MemberId}");
                            //}
                            //Code
                            try
                            {
                                List<Claim> claims = new List<Claim>()
                            {
                                 new Claim(ClaimTypes.NameIdentifier,member.MemberId),
                                 new Claim(ClaimTypes.Email,member.Email),
                                 new Claim(ClaimTypes.Name,member.UserName),
                                 new Claim(ClaimTypes.MobilePhone, member.Phone)
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
                            catch (System.Exception)
                            {

                                ModelState.AddModelError("", "Đang có lỗi xảy ra");
                            }

                        }
                        ModelState.AddModelError("", "Đang có lỗi xảy ra");
                    }
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else
                {
                    ViewBag.ErrorPassword = LoginInformation.CheckLogin(obj);
                }    
            }
            return View();
        }
       
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/auth/login");
        }
        public IActionResult FacebookSignIn()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("FacebookResponse") };
            return Challenge(properties, FacebookDefaults.AuthenticationScheme);
        }
        public async Task<IActionResult> FacebookResponse()
        {
            var result = await HttpContext.AuthenticateAsync(FacebookDefaults.AuthenticationScheme);
            var claims = result.Principal.Identities
                        .FirstOrDefault().Claims.Select(claim => new
                        {
                            claim.Issuer,
                            claim.OriginalIssuer,
                            claim.Type,
                            claim.Value
                        });
            //return Json(claims);
            Member obj = new Member();
            obj.Gender = null;

            obj.Password = "123456";
            foreach (var claim in claims)
            {
                switch (claim.Type)
                {
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier":
                        obj.MemberID = claim.Value;
                        break;
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress":
                        obj.Email = claim.Value;
                          break;
                      case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name":
                        obj.UserName = claim.Value;
                        break;
                }
            }
            ReponseLogin reponse = await provider.Member.LoginOAuth(obj);

            if (reponse != null)
            {

                List<Claim> list2 = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,reponse.MemberId),
                    new Claim(ClaimTypes.Name,obj.UserName),
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
            
            obj.Password = "123456";
            foreach (var claim in claims)
            {
                switch (claim.Type)
                {
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier":
                        obj.MemberID = claim.Value;
                        break;
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress":
                        obj.Email = claim.Value;
                        break;
                    case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name":
                        obj.UserName = claim.Value;
                        break;
                }
            }
            ReponseLogin reponse = await provider.Member.LoginOAuth(obj);

            if (reponse != null)
            {

                List<Claim> list2 = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,reponse.MemberId),
                    new Claim(ClaimTypes.Name,obj.UserName),
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

        [HttpGet]
        public IActionResult DisplayConfirm() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayConfirm(string phone)
        {
            if (PhoneNumber.CheckPhone(phone)) 
            {
                // Send otp code.
                //var code = _forgetPasswordRepository.SendSMS(phone);
                var code = "111111";
                if (code != null)
                {
                    // Save code into session.
                    HttpContext.Session.SetString(Constant.Code, code);

                    // Save phone into session.
                    HttpContext.Session.SetString(Constant.Phone, phone);

                    return RedirectToAction("DisplayConfirmCode");
                }
                ViewBag.ErrorPhoneFormat = "Lỗi gửi mã đã xảy ra";
                return View();
            }
            ViewBag.ErrorPhoneFormat = "Số điện thoại phải là số";
            return View();
        }

        [HttpGet]
        public IActionResult DisplayConfirmCode() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayConfirmCode(string code) 
        {
            var session = HttpContext.Session;
            if (session.GetString(Constant.Code) == code) 
            {
                return RedirectToAction("ResetPassword");
            }
            ViewBag.ErrorCodeOTP = "Mã OTP không đúng!";
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword() 
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string password, string confirmPassword) 
        {
            var session = HttpContext.Session;
            if (PasswordNews.CheckPassword(password, confirmPassword) == "1") 
            {
                if (session.GetString(Constant.Phone) != null)
                {
                    var passwordNew = new PasswordNew() { Password = password, Phone = session.GetString(Constant.Phone) };
                    // Change new password.
                    await provider.Member.ChangePassword(passwordNew);
                    return RedirectToAction("Index", "Home");
                }
            }
            if (session.GetString(Constant.Phone) == null)
            {
                ViewBag.Error = "Hết thời gian thay đổi mật khẩu";
            }
            else if(PasswordNews.CheckPassword(password, confirmPassword) != "1")
            {
                ViewBag.ErrorPasswordNew = PasswordNews.CheckPassword(password, confirmPassword);
            }
            return View();
        }
    }
}
