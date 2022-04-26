﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Models.Repository
{
    public class NewsRepository : BaseRepository
    {
        public NewsRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<News>> GetNews()
        {
            return await Get<List<News>>("/api/news");
        }
        public async Task<int> Add(News news)
        {
            return await Post<News>("/api/news", news);
        }
        public async Task<News> GetNewById(string id)
        {
            return await Get<News>($"/api/news/{id}");
        }
        public async Task<int> Delete(News obj)
        {
            return await Post<News>($"/api/news/delete/{obj.NewsId}",obj);
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
    }
}