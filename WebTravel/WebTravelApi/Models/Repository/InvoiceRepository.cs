using Dapper;
using System;
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
                InvoiceId = obj.InvoiceId,
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
            return connection.Query<InvoiceModel>("select InvoiceDetail.*, MemberId, Status from Invoice join InvoiceDetail on Invoice.InvoiceId = InvoiceDetail.InvoiceId where  Invoice.MemberId = @Id", new {Id = id});
        }
        public InvoiceModel GetInvoiceModelById(string id)
        {
            return connection.QuerySingleOrDefault<InvoiceModel>("select InvoiceDetail.*, MemberId, InvoiceDate, Status from Invoice join InvoiceDetail on Invoice.InvoiceId = InvoiceDetail.InvoiceId where Invoice.InvoiceId = @Id", new { Id = id });

        }
        public int Delete(string id)
        {
            return connection.Execute($"delete from Invoice where InvoiceId = @Id", new { Id = id });
        }
        public int DeleteInvoiceDetail(string id)
        {
            return connection.Execute($"delete from InvoiceDetail where InvoiceId = @Id", new { Id = id });
        }
        public int RestoreQuantity(string id, int quantity)
        {
            return connection.Execute("update Tours set Quantity = (select Quantity from Tours where TourId = @Id)+ @SoLuong where TourId = @Id", new { Id = id, SoLuong = quantity });
        }
        public Invoice GetInvoice(string id)
        {
            return connection.QuerySingleOrDefault<Invoice>("select * from Invoice where InvoiceId = @Id", new { Id = id });
        }
        public IEnumerable<InvoiceModel> GetStatsDay(DateTime time)
        {
            string sql = "select i.Status, i.MemberId, i.InvoiceDate, id.* from Invoice as i join InvoiceDetail as id on i.InvoiceId = id.InvoiceId where Status = 1 and DAY(@Date) = DAY(i.InvoiceDate) and MONTH(@Date) = MONTH(i.InvoiceDate) and YEAR(@Date) = YEAR(i.InvoiceDate)";
            return connection.Query<InvoiceModel>(sql, new { Date = time });
        }
        public IEnumerable<InvoiceModel> GetStatsMonth(DateTime time)
        {
            string sql = "select i.Status, i.MemberId, i.InvoiceDate, id.* from Invoice as i join InvoiceDetail as id on i.InvoiceId = id.InvoiceId where Status = 1 and MONTH(@Date) = MONTH(i.InvoiceDate) and YEAR(@Date) = YEAR(i.InvoiceDate)";
            return connection.Query<InvoiceModel>(sql,new { Date = time});
        }
        public IEnumerable<InvoiceModel> GetStatsYear(DateTime time)
        {
            string sql = "select i.Status, i.MemberId, i.InvoiceDate, id.* from Invoice as i join InvoiceDetail as id on i.InvoiceId = id.InvoiceId where Status = 1 and YEAR(@Date) = YEAR(i.InvoiceDate)";
            return connection.Query<InvoiceModel>(sql, new { Date = time });
        }
        public IEnumerable<InvoiceModel> GetInvoiceModels()
        {
            string sql = "select i.Status, i.MemberId, i.InvoiceDate, id.* from Invoice as i join InvoiceDetail as id on i.InvoiceId = id.InvoiceId";
            return connection.Query<InvoiceModel>(sql);
        }
    }
}
