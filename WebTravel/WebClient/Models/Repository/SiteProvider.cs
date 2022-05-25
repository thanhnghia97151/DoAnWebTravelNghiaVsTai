using Microsoft.Extensions.Configuration;

namespace WebClient.Models.Repository
{
    public class SiteProvider
    {
        IConfiguration configuration;
        public SiteProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        MemberRepository member;
        RoleRepository role;
        MemberInRoleRepository memberInRole;
        TypeOfTourRepository typeOfTour;
        TourCategoryRepository tourCategory;
        TourRepository tour;
        TourScheduleRepository tourSchedule;
        TagRepository tag;
        NewsCategoryRepository newsCategory;
        NewsRepository news;
        NewsTagRepository newsTag;
        AboutRepository about;
        PolicyRepository policy;
        PolicyCategoryRepository policyCategory;
        InvoiceRepository invoice;
        CommentRepository comment;
        ContactRepository contact;

        public ContactRepository Contact
        {
            get
            {
                if (contact is null)
                {
                    contact = new ContactRepository(configuration);
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
                    comment = new CommentRepository(configuration);
                }
                return comment;
            }
        }
        public InvoiceRepository Invoice
        {
            get
            {
                if (invoice is null)
                {
                    invoice = new InvoiceRepository(configuration);
                }
                return invoice;
            }
        }
        public PolicyCategoryRepository PolicyCategory
        {
            get
            {
                if (policyCategory is null)
                {
                    policyCategory = new PolicyCategoryRepository(configuration);   
                }
                return policyCategory;
            }
        }
        public PolicyRepository Policy
        {
            get
            {
                if (policy is null)
                {
                    policy = new PolicyRepository(configuration);
                }
                return policy;
            }
        }
        public AboutRepository About
        {
            get
            {
                if (about is null)
                {
                    about = new AboutRepository(configuration);
                }
                return about;
            }
        }
        public NewsTagRepository NewsTag
        {
            get
            {
                if (newsTag is null)
                {
                    newsTag = new NewsTagRepository(configuration);
                }
                return newsTag;
            }
        }
        public NewsRepository News
        {
            get
            {
                if (news is null)
                {
                    news = new NewsRepository(configuration);
                }
                return news;
            }
        }
        public NewsCategoryRepository NewsCategory
        {
            get
            {
                if (newsCategory is null)
                {
                    newsCategory = new NewsCategoryRepository(configuration);
                }
                return newsCategory;
            }
        }
        public TagRepository Tag
        {
            get
            {
                if (tag is null)
                {
                    tag = new TagRepository(configuration);
                }
                return tag;
            }
        }
        public TourScheduleRepository TourSchedule
        {
            get
            {
                if (tourSchedule is null)
                {
                    tourSchedule = new TourScheduleRepository(configuration);
                }
                return tourSchedule;
            }
        }
        public TourRepository Tour
        {
            get
            {
                if (tour is null)
                {
                    tour = new TourRepository(configuration);
                }
                return tour;
            }
        }
        public TourCategoryRepository TourCategory
        {
            get
            {
                if(tourCategory == null)
                {
                    tourCategory = new TourCategoryRepository(configuration);
                }
                return tourCategory;
            }
        }
        public TypeOfTourRepository TypeOfTour
        {
            get
            {
                if(typeOfTour is null)
                {
                    typeOfTour = new TypeOfTourRepository(configuration);
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
                    memberInRole = new MemberInRoleRepository(configuration);
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
                    role = new RoleRepository(configuration);
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
                    member = new MemberRepository(configuration);
                }
                return member;
            }
        }
    }
}
