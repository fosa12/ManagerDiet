using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Meals.Queries.GetEatedMealsByDate
{
    public class EatedMealVm
    {
        public string MealName { get; set; }
        public int EatedKcal { get; set; }
        public int EatedProtein { get; set; }
        public int EatedCarbo { get; set; }
        public int EatedFat { get; set; }
        public DateTime WhenEated { get; set; }
    }
}
