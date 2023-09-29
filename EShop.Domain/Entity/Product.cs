using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CalculateQty { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductCustomerAttribute> productCustomerAttributes { get; set; }
        public ICollection<ProductInventory> ProductInventories { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<OrderLine> orderLines { get; set; }
    }
}
