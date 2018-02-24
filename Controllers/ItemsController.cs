using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Data;
using Vue2Spa.Models;

namespace Vue2Spa.Controllers
{

    [Route("api/[controller]")]
    public class ItemsController : BaseController
    {
        private ItemsManager manager;
        public ItemsController(IConfiguration config) : base(config)
        {
            manager = new ItemsManager(configuration);
        }
        // GET: api/Items
        [HttpGet]
        public List<Items> Get()
        {
            return manager.GetAll();
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Items
        [HttpPost]
        public Items Post([FromBody]Items value)
        {
            manager.AddItem(value);
            return value;
        }

        // PUT: api/Items
        [HttpPut]
        public Items Put([FromBody]Items value)
        {
            return value;
        }

        // DELETE: api/Items
        [HttpDelete]
        public List<Items> Delete([FromBody]List<Items> value)
        {
            return value;
        }


    }
}
