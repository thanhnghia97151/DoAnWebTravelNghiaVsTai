﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Collections.Generic;
using WebTravelApi.Models;
using WebTravelApi.Models.Repository;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : BaseController
    {
        

        public MemberController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<Member> GetMembers()
        {
            return provider.Member.GetMembers();
        }
        
    }
}
