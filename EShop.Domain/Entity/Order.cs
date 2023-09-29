using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public CustomerAttributeTemplate Cumtumer { get; set; }
        public int StatusId { get; set; }
        public OrderStatus status { get; set; }
        public DateTime OrderAt { get; set; }
        public ICollection<ProductInventory> ProductInventories { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
