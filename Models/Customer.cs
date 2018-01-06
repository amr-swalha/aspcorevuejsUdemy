using Dapper.Contrib.Extensions;

namespace Vue2Spa.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
