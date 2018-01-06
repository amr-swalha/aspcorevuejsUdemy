using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Data;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IConfiguration configuration;
        public CustomerController(IConfiguration config)
        {
            configuration = config;
        }

        [HttpGet("[action]")]
        public IActionResult Result()
        {
            CustomerManager  manager = new CustomerManager(configuration);
            return Ok(manager.GetAll());
        }

    }
}
