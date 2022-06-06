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

        public async Task<int> CheckOut(Invoice obj)
        {
            return await Post<Invoice>("/api/invoice/checkout",obj ); 
        }

        public async Task<List<InvoiceModel>> GetInvoiceModelByMemberId(string id)
        {
            return await Get<List<InvoiceModel>>($"/api/invoice/invoicebymemberid/{id}");
        }

        #region Delete hóa đơn
        public async Task<int> DeleteInvoice(InvoiceModel obj)
        {
            return await Post<InvoiceModel>($"/api/invoice/delete-invoice/{obj.InvoiceId}", obj);
        }
        public async Task<int> DeleteInvoiceDetail(InvoiceModel obj)
        {
            return await Post<InvoiceModel>($"/api/invoice/delete-invoice-detail/{obj.InvoiceId}", obj);
        }
        public async Task<int> RestoreQuantity(InvoiceModel obj)
        {
            return await Post<InvoiceModel>($"/api/invoice/restore-quantity/{obj.TourId}/{obj.Quantity}",obj);
        }
        public async Task<Invoice> GetInvoice(string id)
        {
            return await Get<Invoice>($"/api/invoice/{id}");
        }
        public async Task<InvoiceModel> GetInvoiceModelById(string id)
        {
            return await Get<InvoiceModel>($"/api/invoice/invoicemodel/{id}");
        }
        #endregion

        public async Task<List<InvoiceModel>> GetStatsDay(string time)
        {
            return await Get<List<InvoiceModel>>($"/api/invoice/stastday/{time}");
        }
        public async Task<List<InvoiceModel>> GetStatsMonth(string time)
        {
            return await Get<List<InvoiceModel>>($"/api/invoice/statsmonth/{time}");
        }
        public async Task<List<InvoiceModel>> GetStatsYear(string time)
        {
            return await Get<List<InvoiceModel>>($"/api/invoice/statsyear/{time}");
        }
        public async Task<List<InvoiceModel>> GetInvoiceModels()
        {
            return await Get<List<InvoiceModel>>("/api/invoice/invoicemodels");
        }
    }
}
