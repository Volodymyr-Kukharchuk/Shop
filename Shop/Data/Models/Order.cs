using System;

namespace Shop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime OrderTime { get; set; }
        public IEquatable<OrderDetail> OrderDetail { get; set; }
    }
}
