using EShop.Domain.Entity;
using EShop.Domain.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Repository
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IQueryable _queryable;
        public ProductRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }
}
