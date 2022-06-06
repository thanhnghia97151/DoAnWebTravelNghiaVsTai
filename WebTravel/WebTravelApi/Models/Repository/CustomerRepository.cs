using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebTravelApi.Models.Repository
{
    public class CustomerRepository : BaseRepository
    {
        public CustomerRepository(IDbConnection connection) : base(connection)
        {
        }

        public int Add(Customer obj)
        {
            string sql = "insert into [dbo].[Customer](CustomerID, UserName, Address, Phone, InvoiceId) values(@Id,@UserName,@Address,@Phone,@InvoiceId)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                UserName = obj.UserName,
                Address = obj.Address,
                Phone = obj.Phone,
                InvoiceId = obj.InvoiceId
            });
        }
    }
}
