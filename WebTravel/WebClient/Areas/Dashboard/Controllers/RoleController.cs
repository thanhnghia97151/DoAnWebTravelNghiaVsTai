using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class RoleController:Controller
    {
        SiteProvider provider;
        public RoleController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            List<Role> roles = new List<Role>();    
            roles = await provider.Role.GetRoles();
            return View(roles);
        }
        // Create: 
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Role obj)
        {
            if (ModelState.IsValid)
            {
                await provider.Role.Add(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        
    }
}
