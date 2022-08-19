using ManagerDiet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Domain.Entities
{
    public class CaloricDemand : AuditableEntity
    {
        public double DailyRequirementKcal { get; set; }
        public double DailyRequirementFat { get; set; }
        public double DailyRequirementProtein { get; set; }
        public double DailyRequirementCarbo { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Sex { get; set; }
        public string Activity { get; set; }
        public string Goal { get; set; }
        public int Age { get; set; }
        public int UserInformationId { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
