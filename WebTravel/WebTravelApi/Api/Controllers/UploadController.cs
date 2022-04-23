using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : BaseController
    {
        string Root => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
        public UploadController(IConfiguration configuration) : base(configuration)
        {
        }
        
        [HttpGet]
        public IEnumerable<ImageTour> GetImageTour()
        {
            return provider.ImageTour.GetImageTours();
        }
        [HttpPost]
        public ImageTour Add(IFormFile f,string tId)
        {
            if(f != null)
            {
                string ext = Path.GetExtension(f.FileName);
                string imageUrl = Helper.Helper.RandomString(32 - ext.Length) + ext;
                using (Stream stream = new FileStream(Path.Combine(Root, imageUrl), FileMode.Create))
                {
                    f.CopyTo(stream);
                }
                ImageTour image = new ImageTour
                {
                    ImageContentType = f.ContentType,
                    ImageOriginal = f.FileName,
                    Size = f.Length,
                    ImageUrl = imageUrl,
                    TourId = tId
                };
                return image;
            }
            return null;
        }
    }
}
