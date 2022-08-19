using ManagerDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Persistance.Configurations
{
    public class DietConfiguration : IEntityTypeConfiguration<Diet>
    {
        public void Configure(EntityTypeBuilder<Diet> builder)
        {
            builder.Property(p => p.DietName).HasMaxLength(50).IsRequired();

            builder.Property(p => p.DietShortDescryption).HasMaxLength(50).IsRequired();

            builder.Property(p => p.DietDescryption).HasMaxLength(5000).IsRequired();

            builder.Property(p => p.GlycemicIndex).IsRequired();

            builder.Property(p => p.QuantityProtein).IsRequired();

            builder.Property(p => p.QuantityCarbo).IsRequired();

            builder.Property(p => p.QuantityFat).IsRequired();
    }
    }
}
