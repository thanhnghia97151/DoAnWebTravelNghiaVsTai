using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class ContactRepository : BaseRepository
    {
        public ContactRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> Add(Contact contact)
        {
            return await Post<Contact>("/api/contact", contact);
        }
    }
}
