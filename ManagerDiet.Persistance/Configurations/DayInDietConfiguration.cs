﻿using ManagerDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Persistance.Configurations
{
    public class DayInDietConfiguration : IEntityTypeConfiguration<DayInDiet>
    {
        public void Configure(EntityTypeBuilder<DayInDiet> builder)
        {
            
        }
    }
}
