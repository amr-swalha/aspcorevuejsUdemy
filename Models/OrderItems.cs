using Dapper.Contrib.Extensions;

namespace Vue2Spa.Models
{
    public class OrderItems
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public int Qty { get; set; }

    }
}
