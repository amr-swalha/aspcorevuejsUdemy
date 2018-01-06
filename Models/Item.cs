using Dapper.Contrib.Extensions;

namespace Vue2Spa.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}
