using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MirrorApi.Models;

namespace MirrorApi.Controllers
{
    [Produces("application/json")]
    [Route("api/personas")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TestController : Controller
    {
        private readonly ApplicationDbContext context;
        public TestController(ApplicationDbContext context) {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return context.People.ToList();
        }
    }
}