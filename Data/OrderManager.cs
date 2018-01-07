using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Models;

namespace Vue2Spa.Data
{
    public class OrderManager
    {
        private readonly IConfiguration configuration;
        public OrderManager(IConfiguration config)
        {
            configuration = config;
        }

        public List<Order> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var result = connection.Query<Order, Customer, Order>(
                    "SELECT o.*,c.* FROM dbo.[Order] o JOIN dbo.Customer c ON o.CustomerId = c.Id",
                    ((order, customer) =>
                    {
                        order.Customer = customer;
                        return order;
                    })).ToList();
                return result;
            }
        }
        public List<Order> GetWithItems()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var order = connection.Query<Order>("SELECT * FROM [Order]").ToList();
                var orderItems = connection.Query<OrderItems>("SELECT * FROM OrderItems").ToList();
                foreach (Order order1 in order)
                {
                    order1.Items = new List<OrderItems>(orderItems.Where(x => x.OrderId == order1.Id));
                }
                return order;
            }
        }

        public int AddItem()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {

                return connection.Execute("INSERT INTO [dbo].[Item] ([Name],[Price]) VALUES (@ItemName,@Price)",
                    new {ItemName = "Ipad", Price = 700}, null, null, CommandType.Text);
            }
        }
    }
}
