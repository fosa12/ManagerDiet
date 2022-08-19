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
    public class CaloricDemandConfiguration : IEntityTypeConfiguration<CaloricDemand>
    {
        public void Configure(EntityTypeBuilder<CaloricDemand> builder)
        {
            builder.Property(p => p.DailyRequirementKcal).IsRequired();

            builder.Property(p => p.DailyRequirementFat).IsRequired();

            builder.Property(p => p.DailyRequirementProtein).IsRequired();

            builder.Property(p => p.DailyRequirementCarbo).IsRequired();

            builder.Property(p => p.Weight).IsRequired();

            builder.Property(p => p.Height).IsRequired();

            builder.Property(p => p.Sex).IsRequired();

            builder.Property(p => p.Activity).IsRequired();

            builder.Property(p => p.Goal).IsRequired();

            builder.Property(p => p.Age).IsRequired();
        }
    }
}