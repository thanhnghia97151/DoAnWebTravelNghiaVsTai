using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebTravelApi.Models.Repository
{
    public class SiteProvider
    {
        IConfiguration configuration;
        IDbConnection connection;
        public SiteProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            connection = new SqlConnection(configuration.GetConnectionString("TravelWeb"));
            // Thiếu đóng kết nối
        }
        MemberRepository member;
        RoleRepository role;
        MemberInRoleRepository memberInRole;
        TypeOfTourRepository typeOfTour;
        TourCategoryRepository tourCategory;
        TourScheduleRepository tourSchedule;
        TourRepository tour;
        public TourRepository Tour
        {
            get 
            {
                if (tour is null)
                {
                    tour = new TourRepository(connection);
                }
                return tour;
            }
        }
        public TourScheduleRepository TourSchedule
        {
            get
            {
                if (tourSchedule is null)
                {
                    tourSchedule = new TourScheduleRepository(connection);
                }
                return tourSchedule;
            }
        }
        public TourCategoryRepository TourCategory
        {
            get
            {
                if(tourCategory == null)
                {
                    tourCategory = new TourCategoryRepository(connection);  
                }
                return tourCategory;
            }
        }
        public TypeOfTourRepository TypeOfTour
        {
            get
            {
                if (typeOfTour == null)
                {
                    typeOfTour = new TypeOfTourRepository(connection);
                }
                return typeOfTour;
            }
        }
        public MemberInRoleRepository MemberInRole
        {
            get
            {
                if (memberInRole is null)
                {
                    memberInRole = new MemberInRoleRepository(connection);
                }
                return memberInRole;
            }
        }
        public RoleRepository Role
        {
            get
            {
                if (role is null)
                {
                    role = new RoleRepository(connection);
                }
                return role;
            }
        }
        public MemberRepository Member
        {
            get
            {
                if (member is null)
                {
                    member = new MemberRepository(connection);
                }
                return member;
            }
        }

    }
}
