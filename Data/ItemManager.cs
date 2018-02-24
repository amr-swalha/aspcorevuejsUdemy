using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Models;

namespace Vue2Spa.Data
{
    public class ItemsManager
    {
        private readonly IConfiguration configuration;
        public ItemsManager(IConfiguration config)
        {
            configuration = config;
        }

        public Items GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.Get<Items>(id);
            }
        }
        public List<Items> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.GetAll<Items>().ToList();
            }
        }

        public long AddItem(Items items)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
              return  connection.Insert(items);
            }
        }
        public void UpdateItem(Items items)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Update(items);
            }
        }
        public void DeleteItem(Items items)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Delete(items);
            }
        }

    }
}
