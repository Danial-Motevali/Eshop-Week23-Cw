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
    internal class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Order)
                .WithMany(y => y.OrderLines)
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Product)
                .WithMany(y => y.orderLines)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.ProductPrice)
                .WithMany(y => y.OrderLines)
                .HasForeignKey(x => x.ProductpriceId);
        }
    }
}
