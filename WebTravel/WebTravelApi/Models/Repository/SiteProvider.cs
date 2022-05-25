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
           
        }
        MemberRepository member;
        RoleRepository role;
        MemberInRoleRepository memberInRole;
        TypeOfTourRepository typeOfTour;
        TourCategoryRepository tourCategory;
        TourScheduleRepository tourSchedule;
        TourRepository tour;
        TourMemberRepository tourMember;
        PolicyCategoryRepository tourPolicy;
        PolicyRepository policy;
        AboutRepository about;
        TagRepository tag;
        NewsCategoryRepository newsCategory;
        NewsRepository news;
        NewsTagRepository newsTag;
        ImageTourRepository imageTour;
        InvoiceRepository invoice;
        InvoiceDetailRepository invoiceDetail;
        CommentRepository comment;
        ContactRepository contact;

        public ContactRepository Contact
        {
            get
            {
                if (contact is null)
                {
                    contact = new ContactRepository(connection);
                }
                return contact;
            }
        }
        public CommentRepository Comment
        {
            get
            {
                if (comment is null)
                {
                    comment = new CommentRepository(connection);
                }
                return comment;
            }
        }

        public InvoiceDetailRepository InvoiceDetail
        {
            get
            {
                if (invoiceDetail is null)
                {
                    invoiceDetail = new InvoiceDetailRepository(connection);
                }
                return invoiceDetail;
            }
        }
        public InvoiceRepository Invoice
        {
            get
            {
                if (invoice is null)
                {
                    invoice = new InvoiceRepository(connection);
                }
                return invoice;
            }
        }
        public ImageTourRepository ImageTour
        {
            get
            {
                if (imageTour is null)
                {
                    imageTour = new ImageTourRepository(connection);
                }
                return imageTour;
            }
        }
        public NewsTagRepository NewsTag
        {
            get
            {
                if(newsTag == null)
                {
                    newsTag = new NewsTagRepository(connection);
                }
                return newsTag;
            }
        }
        public NewsRepository News
        {
            get
            {
                if(news is null)
                {
                    news = new NewsRepository(connection);
                }
                return news;
            }
        }
        public NewsCategoryRepository NewsCategory
        {
            get
            {
                if(newsCategory == null)
                {
                    newsCategory = new NewsCategoryRepository(connection);
                }
                return newsCategory;
            }
        }
        public TagRepository Tag
        {
            get
            {
                if(tag is null)
                {
                    tag = new TagRepository(connection);
                }
                return tag;
            }
        }
        public AboutRepository About
        {
            get
            {
                if(about is null)
                {
                    about = new AboutRepository(connection);
                }
                return about;
            }
        }
        public PolicyRepository Policy
        {
            get
            {
                if(policy == null)
                {
                    policy= new PolicyRepository(connection);
                }
                return policy;
            }
        }
        public PolicyCategoryRepository PolicyCategory
        {
            get
            {
                if(tourPolicy == null)
                {
                    tourPolicy = new PolicyCategoryRepository(connection);
                }
                return tourPolicy;
            }
        }
        public TourMemberRepository TourMember
        {
            get
            {
                if(tourMember is null)
                {
                    tourMember = new TourMemberRepository(connection);
                }
                return tourMember;
            }
        }
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
