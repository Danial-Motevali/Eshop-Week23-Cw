using EShop.Domain.Entity;
using EShop.Infrastructure.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.ActiveDirectory.GraphClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure
{
    public class EShopContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EShopContext(DbContextOptions<EShopContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerAttributeTemplate> CustomerAttributeTemplates { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCustomerAttribute> ProductCustomerAttributes { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<ProductPrice> productPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerAttributeTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderLineConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCustomerAttribureConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInvetoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPriceConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
