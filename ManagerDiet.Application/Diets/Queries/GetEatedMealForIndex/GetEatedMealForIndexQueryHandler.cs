using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Queries.GetEatedMealForIndex;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetEatedMealForIndex
{
    public class GetEatedMealForIndexQueryHandler : IRequestHandler<GetEatedMealForIndexQuery, EatedMealForIndexVm>
    {
        private readonly IDietDbContext _context;
        public GetEatedMealForIndexQueryHandler(IDietDbContext dietDbContext)
        {
            _context = dietDbContext;
        }
        public async Task<EatedMealForIndexVm> Handle(GetEatedMealForIndexQuery request, CancellationToken cancellationToken)
        {
            List<EatedMeal> eatedMeals = new List<EatedMeal>();
            EatedMealForIndexVm mapedParametersForIndex = new EatedMealForIndexVm();

            var dayInDiets = await _context.DayInDiets.Where(x => x.DateDayInDiet == request.DateDayInDiet && x.UserInformationId == request.UserId).FirstOrDefaultAsync(cancellationToken);

            if (dayInDiets != null)
                eatedMeals = GetEatedMealsByDayInDietId(dayInDiets.Id);

            if (eatedMeals.Count != 0)
                mapedParametersForIndex = MapEatedMealForIndexVm(eatedMeals);//How to do it better?? I know it's not good becouse i do two operations in one method... but i dont have idea how do it better :C 
            else
                return null;

            return mapedParametersForIndex;


        }

        private EatedMealForIndexVm MapEatedMealForIndexVm(List<EatedMeal> eatedMeals)
        {
            var demandVm = new EatedMealForIndexVm();

            foreach (var eatedMeal in eatedMeals)
            {
                demandVm.EatedProtein += CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.QuantityProteinInGrams);
                demandVm.EatedCarbo += CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.QuantityCarboInGrams);
                demandVm.EatedFat += CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.QuantityFatInGrams);
                demandVm.EatedKcal += CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.KCAL);
            }

            return demandVm;
        }
        private int CalculateValueEatedMakro(int eatedGrams, int quantityInGrams)
        {
            double calculatedValue = (double)(eatedGrams / 100.0 * quantityInGrams);

            return (int)calculatedValue;
        }

        private List<EatedMeal> GetEatedMealsByDayInDietId(int dayInDietId)
        {
            var eatetdMeals = _context.EatedMeals.Where(x => x.DayInDietId == dayInDietId).Include(x => x.Meal).ToList();

            return eatetdMeals;
        }
    }
}
