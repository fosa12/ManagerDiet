using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Queries.GetCaloricDemand;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetCaloricDemand
{
    public class GetCaloricDemandQueryHandler : IRequestHandler<GetCaloricDemandQuery, CaloricDemandVm>
    {
        private readonly IDietDbContext _context;

        public GetCaloricDemandQueryHandler(IDietDbContext context)
        {
            _context = context;
        }

        public async Task<CaloricDemandVm> Handle(GetCaloricDemandQuery request, CancellationToken cancellationToken)
        {
            var caloricDemand = await _context.CaloricDemands.Where(p => p.StatusId == 1 && p.UserInformationId == request.UserId).FirstOrDefaultAsync(cancellationToken);

            return MapedCaloricDemand(caloricDemand);
        }

        private CaloricDemandVm MapedCaloricDemand(CaloricDemand caloricDemand)
        {
            var caloricDemandVm = new CaloricDemandVm()
            {
                DailyRequirementCarbo = caloricDemand.DailyRequirementCarbo,
                DailyRequirementFat = caloricDemand.DailyRequirementFat,
                DailyRequirementKcal = caloricDemand.DailyRequirementKcal,
                DailyRequirementProtein = caloricDemand.DailyRequirementProtein,
                Weight = caloricDemand.Weight,
                Height = caloricDemand.Height,
                Sex = caloricDemand.Sex,
                Activity = caloricDemand.Activity,
                Goal = caloricDemand.Goal,
                Age = caloricDemand.Age
            };

            return caloricDemandVm;
        }
    }
}
