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
    public class CustomerMap:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {   
            // Create Table Customers
            builder.ToTable("Customers");

            // Define Primary Key
            builder.HasKey(c => c.Id);

            // Define Properties
            builder.Property(c=>c.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c=>c.Password)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c=>c.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c=>c.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.ModifiedAt)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(c => c.DateOfBirth)
                .HasColumnType("datetime");
       
        }
    }
}
