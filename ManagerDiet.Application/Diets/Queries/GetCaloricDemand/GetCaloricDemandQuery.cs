using ManagerDiet.Shared.Diets.Queries.GetCaloricDemand;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetCaloricDemand
{
    public class GetCaloricDemandQuery : IRequest<CaloricDemandVm>
    {
        public int UserId { get; set; }
    }
}
