﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    }
}
