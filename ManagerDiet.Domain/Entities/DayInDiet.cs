using ManagerDiet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Domain.Entities
{
    public class DayInDiet : AuditableEntity
    {


        public DateTime DateDayInDiet { get; set; }
        public int UserInformationId { get; set; }
        public UserInformation UserInformation { get; set; }
        public ICollection<EatedMeal> EatedMeals { get; set; }
    }
}































