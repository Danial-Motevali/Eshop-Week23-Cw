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
    internal class CustomerAttributeTemplateConfiguration : IEntityTypeConfiguration<CustomerAttributeTemplate>
    {
        public void Configure(EntityTypeBuilder<CustomerAttributeTemplate> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Category)
                .WithMany(y => y.CustomerAttributeTemplates)
                .HasForeignKey(x => x.CategoryId);

        }
    }
}
