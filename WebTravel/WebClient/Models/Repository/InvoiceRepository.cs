using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Models.Repository
{
    public class InvoiceRepository : BaseRepository
    {
        public InvoiceRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<int> Add(InvoiceDetailModel obj)
        {
            
            return await Post<InvoiceDetailModel>("/api/invoice",obj); 
           
        }
        public async Task<List<Invoice>> GetInvoiceByMemberId(string id)
        {
            return await Get<List<Invoice>>($"/api/invoice/member/{id}");
        }
        //public async Task<int> CheckOut(Invoice obj)
        //{
        //    return await Post<Invoice>("/api/invoice/checkout",obj ); 
        //}
    }
}
