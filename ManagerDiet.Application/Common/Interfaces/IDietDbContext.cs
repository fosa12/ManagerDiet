using ManagerDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Interfaces
{
    public interface IDietDbContext
    {
        DbSet<CaloricDemand> CaloricDemands { get; set; }
        DbSet<DayInDiet> DayInDiets { get; set; }
        DbSet<Diet> Diets { get; set; }
        DbSet<EatedMeal> EatedMeals { get; set; }
        DbSet<Meal> Meals { get; set; }
        DbSet<UserInformation> UserInformations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());


    }
}
