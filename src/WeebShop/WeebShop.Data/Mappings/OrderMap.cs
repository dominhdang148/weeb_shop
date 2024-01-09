using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;
using WeebShop.Core.Entities;

namespace WeebShop.Data.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.CreateDate)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(o => o.TotalAmount)
                .IsRequired();
            builder.Property(o => o.OrderStatus)
                .HasConversion<string>();
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .HasConstraintName("FK_Customer_Order")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
