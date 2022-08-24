using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.CreateCaloricDemand
{
    public class CreateCaloricDemandCommandHandler : IRequestHandler<CreateCaloricDemandCommand, int>
    {
        private readonly IDietDbContext _context;
        public CreateCaloricDemandCommandHandler(IDietDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateCaloricDemandCommand request, CancellationToken cancellationToken)
        {
            CaloricDemand mapedCaloricDemand = MapCreateCaloricDemandVm(request);

            _context.CaloricDemands.Add(mapedCaloricDemand);

            await _context.SaveChangesAsync(cancellationToken);


            return mapedCaloricDemand.Id;
        }
        private CaloricDemand MapCreateCaloricDemandVm(CreateCaloricDemandCommand request)
        {
            CaloricDemand calcualtedMakro = CalculateMakro(request.CaloricDemand);

            CaloricDemand caloricDemandMapped = new CaloricDemand()
            {
                DailyRequirementKcal = calcualtedMakro.DailyRequirementKcal,
                DailyRequirementCarbo = calcualtedMakro.DailyRequirementCarbo,
                DailyRequirementFat = calcualtedMakro.DailyRequirementFat,
                DailyRequirementProtein = calcualtedMakro.DailyRequirementProtein,
                Weight = request.CaloricDemand.Weight,
                Height = request.CaloricDemand.Height,
                Sex = request.CaloricDemand.Sex,
                Activity = request.CaloricDemand.Activity,
                Goal = request.CaloricDemand.Goal,
                Age = request.CaloricDemand.Age,
                UserInformationId = 1
            };

            return caloricDemandMapped;
        }

        private CaloricDemand CalculateMakro(CreateCaloricDemandVm caloricDemand)
        {
            CaloricDemand makroDemandAfterCalculatet = new CaloricDemand();
            switch (caloricDemand.Sex)
            {
                case "Woman":
                    double kcalDemandWoman = 665 + (9.6 * caloricDemand.Weight) + (1.8 * caloricDemand.Height) - (4.7 * caloricDemand.Age);
                    makroDemandAfterCalculatet.DailyRequirementKcal = Math.Ceiling(KcalPAL(kcalDemandWoman, caloricDemand.Activity));

                    makroDemandAfterCalculatet.DailyRequirementCarbo = Math.Ceiling((makroDemandAfterCalculatet.DailyRequirementKcal * 0.5) / 4);

                    makroDemandAfterCalculatet.DailyRequirementProtein = Math.Ceiling((makroDemandAfterCalculatet.DailyRequirementKcal * 0.2) / 4);

                    makroDemandAfterCalculatet.DailyRequirementFat = Math.Ceiling((makroDemandAfterCalculatet.DailyRequirementKcal * 0.3) / 9);
                    break;
                case "Man":
                    double kcalDemandMan = 66 + (13.7 * caloricDemand.Weight) + (5 * caloricDemand.Height) - (6.8 * caloricDemand.Age);
                    makroDemandAfterCalculatet.DailyRequirementKcal = Math.Ceiling(KcalPAL(kcalDemandMan, caloricDemand.Activity));

                    makroDemandAfterCalculatet.DailyRequirementCarbo = Math.Ceiling((makroDemandAfterCalculatet.DailyRequirementKcal * 0.5) / 4);

                    makroDemandAfterCalculatet.DailyRequirementProtein = Math.Ceiling((makroDemandAfterCalculatet.DailyRequirementKcal * 0.2) / 4);

                    makroDemandAfterCalculatet.DailyRequirementFat = Math.Ceiling((makroDemandAfterCalculatet.DailyRequirementKcal * 0.3) / 9);
                    break;
            }
            return makroDemandAfterCalculatet;
        }
        private double KcalPAL(double kcal, string PALActivity)
        {
            if (PALActivity == "Lackofphysicalactivity")
            {
                kcal = kcal * 1.2;
            }
            else if (PALActivity == "Lightactivity")
            {
                kcal = kcal * 1.4;
            }
            else if (PALActivity == "Averageactivity")
            {
                kcal = kcal * 1.6;
            }
            else if (PALActivity == "Highactivity")
            {
                kcal = kcal * 1.8;
            }
            else if (PALActivity == "Veryhighphysicalactivity")
            {
                kcal = kcal * 2.0;
            }
            return kcal;
        }

    }
}
