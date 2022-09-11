using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Meals.Queries.GetEatedMealsByDate
{
    public class EatedMealsVm
    {
        public List<EatedMealVm> EatedMeals { get; set; } = new();
    }
}
