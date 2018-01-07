using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Data;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IConfiguration configuration;
        public OrderController(IConfiguration config)
        {
            configuration = config;
        }

        [HttpGet("[action]")]
        public IActionResult Result()
        {
            OrderManager manager = new OrderManager(configuration);
            return Ok(manager.GetWithItems());
        }
        [HttpGet("[action]")]
        public IActionResult AddItem()
        {
            OrderManager manager = new OrderManager(configuration);
            return Ok(manager.AddItem());
        }

    }
}
