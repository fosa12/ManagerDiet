using ManagerDiet.Shared.Diets.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.CreateCaloricDemand
{
    public class CreateCaloricDemandCommand : IRequest<int>
    {
        public CreateCaloricDemandVm CaloricDemand { get; set; }
    }
}
