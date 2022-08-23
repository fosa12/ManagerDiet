using ManagerDiet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Domain.Entities
{
    public class Ingredient : AuditableEntity
    {
        public string Name { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
