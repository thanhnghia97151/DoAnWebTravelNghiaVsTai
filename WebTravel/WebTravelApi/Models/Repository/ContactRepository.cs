using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebTravelApi.Api.Controllers;

namespace WebTravelApi.Models.Repository
{
    public class ContactRepository : BaseRepository
    {
        public ContactRepository(IDbConnection connection) : base(connection)
        {
        }

        public int Add(Contact contact)
        {
           
            if (contact.CustomerID == null) 
            {
                string sql = "Insert Into [dbo].[Contacts] (ContactId, CreatedAt,Title, Content, Name, Company, Phone, Email, Status) Values(@Id,GETDATE(),@Title,@Content,@Name,@Company,@Phone,@Email,@Status)";
                return connection.Execute(sql, new
                {
                    Id = Helper.Helper.RandomString(64),
                    Name = contact.Name,
                    Title = contact.Title,
                    Content = contact.Content,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Company = contact.Company,
                    Status = true,
                });
            }
            else 
            {
                string sql = "Insert Into [dbo].[Contacts] (ContactId, CreatedAt, Title, Content, Company, CustomerID,Status) Values(@Id,GETDATE(),@Title,@Content,@Company,@MemberId,@Status)";
                return connection.Execute(sql, new
                {
                    Id = Helper.Helper.RandomString(64),
                    Title = contact.Title,
                    Content = contact.Content,
                    Company = contact.Company,
                    MemberId = contact.CustomerID,
                    Status = true,
                });
            }
        }

    }
}
