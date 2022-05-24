using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class CommentController : Controller
    {
        SiteProvider provier;
        public CommentController(IConfiguration configuration)
        {
            provier = new SiteProvider(configuration);
        }
        
    }
}
