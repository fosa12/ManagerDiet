using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Diets.Commands
{
    public class CreateMealVm
    {
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int PreparationTimeInMin { get; set; }
        public string GlycemicIndex { get; set; }
        public int QuantityProteinInGrams { get; set; }
        public int QuantityCarboInGrams { get; set; }
        public double QuantitySugar { get; set; }
        public int QuantityFatInGrams { get; set; }
        public double QuantitySaturatedFatInGrams { get; set; }
        public string Ingredients { get; set; }
        public int KCAL { get; set; }
    }
}
