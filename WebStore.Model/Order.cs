using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public Customer Customer { get; set; }
        public User User { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public Invoice Invoice { get; set; }

        public decimal TotalAmount { get; set; }

        public Order()
        {
            OrderProducts = new List<OrderProduct>();
        }
    }
}