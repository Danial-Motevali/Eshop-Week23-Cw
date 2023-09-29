using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entity
{
    public class CustomerAttributeTemplate
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string AttributeTitle { get; set; }
        public ICollection<ProductCustomerAttribute> ProductCustomerAttributes { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
