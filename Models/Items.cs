using Dapper.Contrib.Extensions;

namespace Vue2Spa.Models
{
    [Table("Items")]
    public class Items
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}
