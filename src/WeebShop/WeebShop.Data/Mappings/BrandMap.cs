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
   public class BrandMap: IEntityTypeConfiguration<Brand>
    {
       public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(b => b.UrlSlug)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasOne(b => b.Logo)
                .WithOne(i => i.Brand)
                .HasForeignKey<Brand>(b => b.LogoId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Property(b => b.Description)
                .HasMaxLength(1000);
        }
    }
}
