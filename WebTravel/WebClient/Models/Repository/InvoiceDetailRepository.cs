using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class InvoiceDetailRepository : BaseRepository
    {
        public InvoiceDetailRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<InvoiceDetail> GetInvoiceDetailByInvoiceId(string id)
        {
            return await Get<InvoiceDetail>($"/api/invoicedetail/{id}");
        }
    }
}
