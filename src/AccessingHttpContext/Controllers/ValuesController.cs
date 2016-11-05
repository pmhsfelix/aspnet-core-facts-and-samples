using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AccessingHttpContext.Controllers
{
    [Route("api/[controller]")]
    public class ResourcesController : Controller
    {
        private readonly HttpContext httpContext;

        //private readonly IHttpContextAccessor httpContextAccessor;

        public ResourcesController(
            // IHttpContextAccessor httpContextAccessor
            HttpContext httpContext
            )
        {
            //this.httpContextAccessor = httpContextAccessor;
            this.httpContext = httpContext;
        }

        [HttpGet]
        public string Get()
        {
            //return httpContextAccessor.HttpContext.Request.Headers["user-agent"];
            return httpContext.Request.Headers["user-agent"];
        }
    }
}