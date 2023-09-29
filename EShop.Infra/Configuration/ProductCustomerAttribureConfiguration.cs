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
    internal class ProductCustomerAttribureConfiguration : IEntityTypeConfiguration<ProductCustomerAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductCustomerAttribute> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Product)
                .WithMany(y => y.productCustomerAttributes)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Attribute)
                .WithMany(y => y.ProductCustomerAttributes)
                .HasForeignKey(u => u.AttributeId);

        }
    }
}
