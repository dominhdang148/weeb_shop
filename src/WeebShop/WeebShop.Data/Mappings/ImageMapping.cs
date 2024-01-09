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
    public class ImageMapping:IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name)
                .HasMaxLength(100);
            builder.Property(i => i.ImageUrl)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
