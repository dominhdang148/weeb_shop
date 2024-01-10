using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Entities;

namespace WeebShop.Data.Mappings
{
    public class AddressMap:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            // Create Table Addesses
            builder.ToTable("Addresses");

            // Define Primary Key
            builder.HasKey(a => a.Id);

            // Define Properties
            builder.Property(a => a.AddressLine)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a=>a.City)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.PostalCode)
                .HasMaxLength(10);
            builder.Property(a => a.Telephone)
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(a => a.Mobile)
                .HasMaxLength(10);

            // Define Foreign Key
            builder.HasOne(a=>a.Customer)
                .WithMany(c=>c.Addresses)
                .HasForeignKey(a=>a.CustomerId)
                .HasConstraintName("FK_Customer_Address")
                .OnDelete(DeleteBehavior.Cascade);  
        }
    }
}
