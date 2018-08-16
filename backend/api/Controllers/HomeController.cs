using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using api.Options;

namespace api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly SystemInfo _systemInfo;

        public HomeController(IOptions<SystemInfo> systemInfo)
        {
            _systemInfo = systemInfo.Value;
        }

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

            return _systemInfo;
        }
    }
}