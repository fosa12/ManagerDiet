using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Diets.Queries.GetMealLists
{
    public class MealForListVm
    {
        public string Name { get; set; }
        public int PreparationTimeInMin { get; set; }
        public string GlycemicIndex { get; set; }
        public int QuantityProteinInGrams { get; set; }
        public int QuantityCarboInGrams { get; set; }
        public int QuantityFatInGrams { get; set; }
    }
}
