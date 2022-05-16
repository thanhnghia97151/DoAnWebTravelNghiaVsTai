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
            string sql = "insert into Members(MemberID,UserName,Password,Email,Phone) values(@Id,@UserName,@Password,@Email,@Phone)";
            var t = new
            {
                Id = Helper.Helper.RandomString(64),
                UserName = obj.UserName,
                Password = Helper.Helper.Hash(obj.Password),
                Email = obj.Email,
                Phone = obj.Phone
            };
            var result = connection.Execute(sql,t );
            return result;
        }
        public Member Login(LoginModel login)
        {
            string sql = "select MemberID,UserName,Email,Gender from Members where UserName=@Urs and Password=@Pwd";
            return connection.QuerySingleOrDefault<Member>(sql, new
            {
                Urs = login.Urs,
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
        public int ConfirmNumberPhone(string id)
        {
            return connection.Execute("update Members set ConfirmedPhone = 1 where MemberID = @Id", new { Id = id });
        }
    }
}
