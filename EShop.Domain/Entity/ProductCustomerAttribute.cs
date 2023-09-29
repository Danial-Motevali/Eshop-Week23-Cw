using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entity
{
    public class ProductCustomerAttribute
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AttributeId { get; set; }
        public CustomerAttributeTemplate Attribute { get; set; }
        public string AttributeTitle { get; set; }
        public string AttributeValue { get; set; }
    }
}
