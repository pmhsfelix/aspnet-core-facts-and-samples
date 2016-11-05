using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomMediaTypeResponse.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ErrorModel Get()
        {
            Response.StatusCode = 403;
            Response.Headers["content-type"] = "application/problem+json";
            return new ErrorModel
            {
                Type = new Uri("https://example.com/cant/touch/this"),
            };
        }        
    }

    public class ErrorModel
    {
        public Uri Type { get; set; }
    }
}
