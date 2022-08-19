using ManagerDiet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Domain.Entities
{
    public class EatedMeal : AuditableEntity
    {
        public int EatedGrams { get; set; }
        public DateTime WhenEated { get; set; }
        public int DayInDietId { get; set; }
        public DayInDiet DayInDiet { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
