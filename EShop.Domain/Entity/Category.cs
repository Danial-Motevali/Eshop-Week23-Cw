using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public bool HasProduct { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<CustomerAttributeTemplate> CustomerAttributeTemplates { get; set; }
    }
}
