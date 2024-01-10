using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Entities;

namespace WeebShop.Data.Mappings
{
    public class PaymentMethodMap:IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            // Create table
            builder.ToTable("PaymentMethods");

            // Define Primary Key
            builder.HasKey(pm => pm.Id);

            // Define Properties
            builder.Property(pm => pm.Provider)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(pm => pm.AccountNo)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(pm => pm.Expiry)
                .IsRequired()
                .HasColumnType("datetime");

            // Define Foreign Key
            builder.HasOne(pm=>pm.Customer)
                .WithMany(c=>c.PaymentMethods)
                .HasForeignKey(pm=>pm.CustomerId)
                .HasConstraintName("FK_Customers_PaymentMethods")
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
