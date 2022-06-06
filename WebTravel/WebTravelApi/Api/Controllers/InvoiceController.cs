using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using WebTravelApi.Models;
using WebTravelApi.Models.Repository;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : BaseController
    {
        public InvoiceController(IConfiguration configuration) : base(configuration)
        {
        }

        [HttpPost]
        public int Add(InvoiceDetailModel obj)
        {
            var t = provider.Invoice.Add(obj);
            return t;

        }
        [HttpGet("member/{id}")]
        public IEnumerable<Invoice> GetInvoiceByUserId(string id)
        {
            return provider.Invoice.GetInvoiceByMemberId(id);
        }
        [HttpPost("checkout")]
        public int CheckOut(Invoice obj)
        {
            return provider.Invoice.CheckOut(obj);
        }

        [HttpGet("invoicebymemberid/{id}")]
        public IEnumerable<InvoiceModel> GetInvoiceModelByMemberId(string id)
        {
            return provider.Invoice.GetInvoiceModel(id);
        }
        [HttpPost("delete-invoice/{id}")]
        public int DeleteInvoice(string id)
        {
            return provider.Invoice.Delete(id);
        }
        [HttpPost("delete-invoice-detail/{id}")]
        public int DeleteInvoiceDetail(string id)
        {
            return provider.Invoice.DeleteInvoiceDetail(id);
        }
        [HttpPost("restore-quantity/{id}/{soluong}")]
        public int RestoreQuantity(string id, int soluong)
        {
            return provider.Invoice.RestoreQuantity(id, soluong);
        }
        [HttpGet("{id}")]
        public Invoice GetInvoice(string id)
        {
            return provider.Invoice.GetInvoice(id);
        }
        [HttpGet("invoicemodel/{id}")]
        public InvoiceModel GetInvoiceModel(string id)
        {
            return provider.Invoice.GetInvoiceModelById(id);
        }
        [HttpGet("stastday/{id}")]
        public IEnumerable<InvoiceModel> GetStatsDay(string id)         
        {
            var timeConvert = Convert.ToDateTime(id);
            return provider.Invoice.GetStatsDay(timeConvert);
        }
        [HttpGet("statsmonth/{id}")]
        public IEnumerable<InvoiceModel> GetStatsMonth(string id)
        {
            DateTime convert = Convert.ToDateTime(id);
            return provider.Invoice.GetStatsMonth(convert);
        }
        [HttpGet("statsyear/{id}")]
        public IEnumerable<InvoiceModel> GetStatsYear(string id)
        {
            DateTime convert = Convert.ToDateTime(id);
            return provider.Invoice.GetStatsYear(convert);
        }
        [HttpGet("invoicemodels")]
        public IEnumerable<InvoiceModel> GetInvoiceModels()
        {
            return provider.Invoice.GetInvoiceModels();
        }
    }
}
