using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entity
{
    public class ProductInventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Ordere { get; set; }
        public int QTY { get; set; }
        public  bool IsAppend { get; set; }
        public DateTime ActionAt { get; set; }
    }
}
