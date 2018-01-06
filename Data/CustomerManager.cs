using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Models;

namespace Vue2Spa.Data
{
    public class CustomerManager
    {
        private readonly IConfiguration configuration;
        public CustomerManager(IConfiguration config)
        {
            configuration = config;
        }

        public List<Customer> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var customers = connection.Query<Customer>("SELECT * FROM Customer").ToList();
                return customers;
            }
        }
    }
}
