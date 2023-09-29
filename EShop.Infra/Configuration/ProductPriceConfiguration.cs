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
    internal class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Product)
                .WithMany(y => y.ProductPrices)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
