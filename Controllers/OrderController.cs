using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Data;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IConfiguration configuration;
        public OrdersController(IConfiguration config)
        {
            configuration = config;
        }

        [HttpGet("[action]")]
        public IActionResult Result()
        {
            OrdersManager manager = new OrdersManager(configuration);
            return Ok(manager.GetWithItems());
        }
        [HttpGet("[action]")]
        public IActionResult AddItem()
        {
            OrdersManager manager = new OrdersManager(configuration);
            return Ok(manager.AddItem());
        }
        [HttpGet("[action]")]
        public IActionResult GetById(int id)
        {
            OrdersManager manager = new OrdersManager(configuration);
            return Ok(manager.GetById(id));
        }
        [HttpGet("[action]")]
        public IActionResult GetAllContrib()
        {
            OrdersManager manager = new OrdersManager(configuration);
            return Ok(manager.GetAllContrib());
        }
        [HttpGet("[action]")]
        public IActionResult Add()
        {
            OrdersManager manager = new OrdersManager(configuration);
            return Ok(manager.AddOrder());
        }
        [HttpGet("[action]")]
        public IActionResult Update()
        {
            OrdersManager manager = new OrdersManager(configuration);
            manager.UpdateOrder();
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult Delete()
        {
            OrdersManager manager = new OrdersManager(configuration);
            manager.DeleteOrder();
            return Ok();
        }

    }
}
