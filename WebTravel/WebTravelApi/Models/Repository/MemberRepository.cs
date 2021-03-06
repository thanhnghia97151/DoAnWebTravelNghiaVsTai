using Dapper;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Models.Repository
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(IDbConnection connection) : base(connection)
        {
            
        }
       
        public IEnumerable<Member> GetMembers()
        {
            return connection.Query<Member>("select * from Members");
        }
        public Member GetMemberById(string id)
        {
            string sql = "select * from Members where MemberID = @Id";
            return connection.QuerySingleOrDefault<Member>(sql, new { Id = id });
        }

        public Member GetMemberByPhone(string phone)
        {
            string sql = "select * from Members where Phone = @Phone";
            return connection.QuerySingleOrDefault<Member>(sql, new { Phone = phone });
        }

        public int AddMemberByGoogle(Member obj)
        {
            string sql = "insert into Members(MemberID,UserName,Password,Email,Gender,ConfirmedPhone) values(@Id,@UserName,@Password,@Email,@Gender,@ConfirmedPhone)";
            return connection.Execute(sql, new
            {
                Id = obj.MemberID,
                UserName = obj.UserName,
                Password = Helper.Helper.Hash(obj.Password),
                Email = obj.Email,
                Gender = obj.Gender,
                ConfirmedPhone = true
            }) ;
        }
        public int Add(Member obj)
        {
            string sql = "insert into Members(MemberID,UserName,Brithday,Address,Password,Email,Phone) values(@Id,@UserName,@Brithday,@Address,@Password,@Email,@Phone)";
            var t = new
            {
                Id = Helper.Helper.RandomString(64),
                UserName = obj.UserName,
                Password = Helper.Helper.Hash(obj.Password),
                Email = obj.Email,
                Phone = obj.Phone,
                Brithday = obj.Birthday,
                Address = obj.Address
            };
            var result = connection.Execute(sql,t );
            return result;
        }
        public Member Login(LoginModel login)
        {
            string sql = "select MemberID,UserName,Email,Gender,Phone from Members where Phone=@Phone and Password=@Pwd and ConfirmedPhone = 1";
            return connection.QuerySingleOrDefault<Member>(sql, new
            {
                Phone = login.Phone,
                Pwd = Helper.Helper.Hash(login.Pwd)
            });
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from Members where MemeberID = @Id", new { Id = id });
        }
        
        public int ChangePassword(ChangePassword obj)
        {
            return connection.Execute("update Members set Password = @Pwd where MemberID = @Id ", new { Id = obj.Id, Pwd = Helper.Helper.Hash(obj.NewPassword) });
        }

        public int ForgetPassword(PasswordNew passwordNew)
        {
            return connection.Execute("update Members set Password = @Password, ConfirmedPhone = 1 where Phone = @Phone ", new { Password = Helper.Helper.Hash(passwordNew.Password), Phone = passwordNew.Phone });
        }

        public int ConfirmNumberPhone(string id)
        {
            return connection.Execute("update Members set ConfirmedPhone = 1 where MemberID = @Id", new { Id = id });
        }
        public int ConfirmStatusPhone(string phone)
        {
            return connection.Execute("update Members set ConfirmedPhone = 1 where Phone = @Phone", new { Phone = phone });
        }

    }
}
