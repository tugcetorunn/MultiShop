using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(s => s.SliderId);
            builder.Property(p => p.SliderId)
                   .ValueGeneratedOnAdd();
            builder.Property(s => s.Header)
                   .IsRequired() 
                   .HasMaxLength(50);
            builder.Property(s => s.Content)
                   .HasMaxLength(70)
                   .IsRequired();
            builder.Property(s => s.Image)
                   .IsRequired();
            builder.Property(s => s.Position)
                   .IsRequired();

        }
    }
}
