using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Diets.Queries.GetEatedMealForIndex
{
    public class EatedMealForIndexVm
    {
        public int EatedKcal { get; set; }
        public int EatedProtein { get; set; }
        public int EatedFat { get; set; }
        public int EatedCarbo { get; set; }
    }
}
