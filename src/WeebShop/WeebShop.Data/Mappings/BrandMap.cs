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
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.UrlSlug)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.LogoUrl)
                .HasMaxLength(500);
            builder.Property(a => a.Description)
                .HasMaxLength(1000);
        }
    }
}
