using ManagerDiet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Domain.Entities
{
    public class Diet : AuditableEntity
    {
        public string DietName { get; set; }
        public string DietShortDescryption { get; set; }
        public string DietDescryption { get; set; }
        public string GlycemicIndex { get; set; }
        public string QuantityProtein { get; set; }
        public string QuantityCarbo { get; set; }
        public string QuantityFat { get; set; }
        public ICollection<UserInformation> UserInformations { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
