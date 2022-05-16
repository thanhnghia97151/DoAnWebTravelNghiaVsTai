using Dapper;
using System.Data;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Models.Repository
{
    public class InvoiceDetailRepository : BaseRepository
    {
        public InvoiceDetailRepository(IDbConnection connection) : base(connection)
        {
        }
        public int Add(InvoiceDetailModel obj)
        {
            return connection.Execute("AddInvoiceDetail", new
            {
                InvoiceId = obj.InvoiceId,
                TourId = obj.TourId,
                Price = obj.Price,
                Quantity = obj.Quantity,
                Paymentt = ((int)obj.Payment),
                QuantityDepartment = obj.QuantityDepartment,
                Description = obj.Description,
                PaymentMore = obj.PaymentMore,
                FullName = obj.FullName,
                Phone = obj.Phone,
                Email = obj.Email

            }, commandType: CommandType.StoredProcedure) ;
        }
        public InvoiceDetail GetInvoiceDetailByInvoiceId(string id)
        {
            return connection.QueryFirstOrDefault<InvoiceDetail>("select * from InvoiceDetail where InvoiceId = @Id", new { Id = id });
        }
    }
}
