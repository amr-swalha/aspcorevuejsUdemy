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
        public Items Get(int id)
        {
            return manager.GetById(id);
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
            manager.UpdateItem(value);
            return value;
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            manager.DeleteItem(new Items{Id = id});
            return id;
        }
    }
}
