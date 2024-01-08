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
            builder.ToTable("Customers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c=>c.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c=>c.DateOfBirth)
                .HasColumnType("datetime");
            builder.Property(c => c.Address)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
