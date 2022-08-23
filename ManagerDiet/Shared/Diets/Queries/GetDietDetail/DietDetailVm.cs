using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Diets.Queries.GetDietDetail
{
    public class DietDetailVm
    {
        public string DietName { get; set; }
        public string DietShortDescryption { get; set; }
        public string DietDescryption { get; set; }
        public string GlycemicIndex { get; set; }
        public string QuantityProtein { get; set; }
        public string QuantityCarbo { get; set; }
        public string QuantityFat { get; set; }
    }
}
