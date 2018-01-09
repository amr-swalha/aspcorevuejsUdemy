using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Vue2Spa.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        public string OrderName { get; set; }

        public int CustomerId { get; set; }
        [Computed]
        public decimal Total { get; set; }
        [Write(false)]
        public Customer Customer { get; set; }
        [Write(false)]
        public List<OrderItems> Items { get; set; }
    }
}
