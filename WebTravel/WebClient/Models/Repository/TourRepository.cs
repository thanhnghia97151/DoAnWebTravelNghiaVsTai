using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Models.Repository
{
    public class TourRepository:BaseRepository
    {
       
        public TourRepository(IConfiguration configuration) : base(configuration)
        {
            
        }
        public async Task<IEnumerable<Tour>> GetTours()
        {
            return await Get<List<Tour>>("/api/tour");
        }
        public async Task<int> Add(Tour obj)
        {
            return await Post<Tour>("/api/tour", obj);
        }
        public async Task<Tour> GetTourById(string id)
        {
            return await Get<Tour>($"/api/tour/{id}");
        }
        public async Task<int> Delete(News obj)
        {
            return await Post<News>($"/api/tour/delete/{obj.NewsId}", obj);
        }
        public async Task<Image> AddImage(IFormFile f)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = uri;
                var content = new MultipartFormDataContent();
                content.Add(new StreamContent(f.OpenReadStream()), "f", f.FileName);

                HttpResponseMessage message = await client.PostAsync("/api/upload/", content);
                if (message.IsSuccessStatusCode)
                {
                    return await message.Content.ReadAsAsync<Image>();
                }
            }
            return null;

        }
        public async Task<List<Tour>> GetTourByCategoryId(string id)
        {
            return await Get<List<Tour>>($"/api/tour/newcategory/{id}");
        }
    }
}
