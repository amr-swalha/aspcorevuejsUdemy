using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Models;

namespace Vue2Spa.Data
{
    public class OrdersManager
    {
        private readonly IConfiguration configuration;
        public OrdersManager(IConfiguration config)
        {
            configuration = config;
        }

        public List<Orders> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var result = connection.Query<Orders, Customer, Orders>(
                    "SELECT o.*,c.* FROM dbo.[Orders] o JOIN dbo.Customer c ON o.CustomerId = c.Id",
                    ((Orders, customer) =>
                    {
                        Orders.Customer = customer;
                        return Orders;
                    })).ToList();
                return result;
            }
        }
        public List<Orders> GetWithItems()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var Orders = connection.Query<Orders>("SELECT * FROM [Orders]").ToList();
                var OrdersItems = connection.Query<OrderItems>("SELECT * FROM OrdersItems").ToList();
                foreach (Orders Orders1 in Orders)
                {
                    Orders1.Items = new List<OrderItems>(OrdersItems.Where(x => x.OrderId == Orders1.Id));
                }
                return Orders;
            }
        }

        public int AddItem()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                
                return connection.Execute("INSERT INTO [dbo].[Items] ([Name],[Price]) VALUES (@ItemName,@Price)",
                    new {ItemName = "Ipad", Price = 700}, null, null, CommandType.Text);
            }
        }
        public Orders GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.Get<Orders>(id);
            }
        }
        public List<Orders> GetAllContrib()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.GetAll<Orders>().ToList();
            }
        }

        public long AddOrder()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                List<Orders> orders = new List<Orders>();
                for (int i = 0; i < 3; i++)
                {
                    orders.Add(new Orders(){CustomerId = 1, OrderName = $"Order Number: {i}", Total = 7678});
                }
              return  connection.Insert(orders);
            }
        }
        public void UpdateOrder()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var orders = connection.GetAll<Orders>().ToList();
                foreach (var order in orders)
                {
                    order.Total =2000;
                }
                connection.Update(orders);
            }
        }
        public void DeleteOrder()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var orders = connection.GetAll<Orders>().ToList();
                connection.Delete(orders.Where(x => x.Id > 3));
            }
        }

    }
}
