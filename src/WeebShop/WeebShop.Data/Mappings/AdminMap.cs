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
    public class AdminMap:IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.IsSuperadmin)
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property(a => a.JoinedDate)
                .HasColumnType("datetime");
            builder.Property(a=>a.ContactNumber)
                .IsRequired()
                .HasMaxLength(11);
            builder.Property("Address")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.AccountStatus)
               .IsRequired()
               .HasConversion<string>();
         }
    }
}
