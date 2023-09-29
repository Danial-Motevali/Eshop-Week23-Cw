using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Configuration
{
    internal class ProductInvetoryConfiguration : IEntityTypeConfiguration<ProductInventory>
    {
        public void Configure(EntityTypeBuilder<ProductInventory> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Product)
                .WithMany(y => y.ProductInventories)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Ordere)
                .WithMany(y => y.ProductInventories)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
