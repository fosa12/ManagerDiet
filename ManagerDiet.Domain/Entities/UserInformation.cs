using ManagerDiet.Domain.Common;
using ManagerDiet.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Domain.Entities
{
    public class UserInformation : AuditableEntity
    {
        public PersonName UserInformationName { get; set; }
        public int DietId { get; set; }
        public Diet Diet { get; set; }
        public ICollection<DayInDiet> DayInDiets { get; set; }
        public CaloricDemand CaloricDemand { get; set; }

    }
}
