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
    public class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.Property(p => p.Recipe).IsRequired();

            builder.Property(p => p.PreparationTimeInMin).IsRequired();

            builder.Property(p => p.GlycemicIndex).IsRequired();

            builder.Property(p => p.QuantityProteinInGrams).IsRequired();

            builder.Property(p => p.QuantityCarboInGrams).IsRequired();

            builder.Property(p => p.QuantitySugar).IsRequired();

            builder.Property(p => p.QuantityFatInGrams).IsRequired();

            builder.Property(p => p.QuantitySaturatedFatInGrams).IsRequired();
        }
    }
}
