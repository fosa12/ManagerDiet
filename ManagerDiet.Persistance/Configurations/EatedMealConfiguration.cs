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
    public class EatedMealConfiguration : IEntityTypeConfiguration<EatedMeal>
    {
        public void Configure(EntityTypeBuilder<EatedMeal> builder)
        {
            builder.Property(p => p.EatedGrams).IsRequired();

            builder.Property(p => p.WhenEated).IsRequired();

            builder.Property(p => p.DayInDietId).IsRequired();

            builder.Property(p => p.MealId).IsRequired();
        }
    }
}
