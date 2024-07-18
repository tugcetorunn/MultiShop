using Microsoft.EntityFrameworkCore;
using MultiShop.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.Extensions
{
    public static class EntityConfigurationsExtension
    {
        public static void ModelBuilderExtension(this ModelBuilder modelBuilder) 
        {
            // entity configuration larının uygulamaya alındığı tetiklendiği yer;
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SliderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCommentConfiguration());
        }
    }
}
