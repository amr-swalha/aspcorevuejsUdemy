using Dapper.Contrib.Extensions;

namespace Vue2Spa.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string OrderName { get; set; }

        public int CustomerId { get; set; }

        public decimal Total { get; set; }

    }
}
