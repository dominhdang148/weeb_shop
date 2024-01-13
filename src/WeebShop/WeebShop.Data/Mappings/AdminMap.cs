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
    public class AdminMap: IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            // Craete table Admins
            builder.ToTable("Admins");

            // Define Primary key 
            builder.HasKey(a => a.Id);

            // Define Properties
            builder.Property(a=>a.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a=>a.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.IsSuperadmin)
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property(a => a.CreatedAt)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(a => a.ModifiedAt)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(a => a.LastLogin)
                .IsRequired()
                .HasColumnType("datetime");
        }
    }
}
