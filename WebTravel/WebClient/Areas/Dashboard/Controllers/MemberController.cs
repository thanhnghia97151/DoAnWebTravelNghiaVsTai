using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class MemberController : Controller
    {
        SiteProvider provider;
        public MemberController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            return View(await provider.Member.GetMembersAsyn());
        }
        public async Task<IActionResult> Role(string id)
        {
            ViewBag.roles = await provider.Role.GetRoleCheckeds(id);
            return View(await provider.Member.GetMemberById(id));
        }
        public async Task<IActionResult> AddRoles(MemberInRole obj)
        {
            return Json(await provider.MemberInRole.Add(obj));
        }
    }
}
