using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Vue2Spa.Controllers
{
    [Produces("application/json")]
    public class BaseController: Controller
    {
        public readonly IConfiguration configuration;
        public BaseController(IConfiguration config)
        {
            configuration = config;
        }
    }
}
