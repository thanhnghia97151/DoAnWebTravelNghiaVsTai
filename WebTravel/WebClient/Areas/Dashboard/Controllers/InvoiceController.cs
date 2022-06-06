using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class InvoiceController : Controller
    {
        SiteProvider provider;
        public InvoiceController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            List<InvoiceModel> result = await provider.Invoice.GetInvoiceModels();
            if (result != null)
            {
                foreach (var item in result)
                {
                    item.Tour = await provider.Tour.GetTourById(item.TourId);
                }
            }

            return View(result);
        }
      
        public async Task<IActionResult> Delete(string id)
        {
            InvoiceModel obj = await provider.Invoice.GetInvoiceModelById(id);
            if (obj != null)
            {
                await provider.Invoice.DeleteInvoiceDetail(obj);
                await provider.Invoice.DeleteInvoice(obj);
                var restore = await provider.Invoice.RestoreQuantity(obj);
                return Redirect("/dashboard/invoice");
            }
            return NotFound();
        }
    }
}
