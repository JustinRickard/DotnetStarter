using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get()
        {
            // TODO: Set dynamically
            var info = new {
                Environment = "Development",
                Version = "1.0.0",
                Author = new {
                    Name = "Justin Rickard",
                    GitHub = "https://github.com/JustinRickard"
                }
            };

            return info;
        }
    }
}