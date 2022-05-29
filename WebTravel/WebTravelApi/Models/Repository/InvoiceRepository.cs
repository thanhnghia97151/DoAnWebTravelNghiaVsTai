using Dapper;
using System.Collections.Generic;
using System.Data;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Models.Repository
{
    public class InvoiceRepository : BaseRepository
    {
        public InvoiceRepository(IDbConnection connection) : base(connection)
        {
        }
        public int Add(InvoiceDetailModel obj)
        {
            return connection.Execute("AddInvoice", new
            {
                InvoiceId = Helper.Helper.RandomString(64),
                Address = obj.Address,
                MemberId = obj.MemberId,
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
            }, commandType: CommandType.StoredProcedure);
            //return connection.Execute("insert into Invoice(InvoiceId,Address,MemberId) values (@InvoiceId,@Address,@MemberId)", new { InvoiceId = Helper.Helper.RandomString(64), Address = obj.Address, MemberId = obj.MemberId });
        }
        public IEnumerable<Invoice> GetInvoiceByMemberId(string id)
        {
            return connection.Query<Invoice>("select * from Invoice where MemberId = @Id", new { Id = id });
        }
        public int CheckOut(Invoice obj)
        {
            return connection.Execute($"update Invoice set Status = 1 where InvoiceId = '{obj.InvoiceId}' and MemberId = '{obj.MemberId}'");
        }
        
        public IEnumerable<InvoiceModel> GetInvoiceModel(string id)
        {
            return connection.Query<InvoiceModel>("select InvoiceDetail.*, MemberId, Status from Invoice join InvoiceDetail on Invoice.InvoiceId = InvoiceDetail.InvoiceId where Invoice.MemberId = @Id", new {Id = id});
        }

        
    }
}
