using ManagerDiet.Application.Interfaces;
using ManagerDiet.Application.Meals.Queries.GetEatedMealLists;
using ManagerDiet.Shared.Meals.Queries.GetEatedMealsByDate;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerDiet.Domain.Entities;

namespace ManagerDiet.Application.Meals.Queries.GetEatedMealList
{
    public class GetEatedMealListQueryHandler : IRequestHandler<GetEatedMealListQuery, EatedMealsVm>
    {
        private readonly IDietDbContext _context;
        public GetEatedMealListQueryHandler(IDietDbContext dietDbContext)
        {
            _context = dietDbContext;
        }
        public async Task<EatedMealsVm> Handle(GetEatedMealListQuery request, CancellationToken cancellationToken)
        {
            int dayInDietId = GetDayInDietsId(request.DateDayInDiet, request.UserId); //await _context.DayInDiets.Where(x => x.DateDayInDiet == request.DateDayInDiet && x.UserInformationId == request.UserId).Select(x => x.Id).FirstOrDefaultAsync(cancellationToken);

            var eatetdMeals = await _context.EatedMeals.Where(x => x.DayInDietId == dayInDietId).Include(x => x.Meal).ToListAsync(cancellationToken);

            return MapEatedMealsToEatedMealsVm(eatetdMeals);
        }
        private int GetDayInDietsId(DateTime dateDayInDiet, int userId)
        {
            var dayInDietsId = _context.DayInDiets.Where(x => x.DateDayInDiet == dateDayInDiet && x.UserInformationId == userId).FirstOrDefault();

            return dayInDietsId.Id;
        }
        private EatedMealsVm MapEatedMealsToEatedMealsVm(List<EatedMeal> eatedMeals)
        {
            EatedMealsVm eatedMealsVm = new EatedMealsVm();

            foreach (var eatedMeal in eatedMeals)
            {
                var eatedMealVm = new EatedMealVm()
                {
                    MealName = eatedMeal.Meal.Name,
                    EatedKcal = CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.KCAL),
                    EatedProtein = CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.QuantityProteinInGrams),
                    EatedCarbo = CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.QuantityCarboInGrams),
                    EatedFat = CalculateValueEatedMakro(eatedMeal.EatedGrams, eatedMeal.Meal.QuantityFatInGrams),
                    WhenEated = eatedMeal.WhenEated
                };
                eatedMealsVm.EatedMeals.Add(eatedMealVm);
            }
            return eatedMealsVm;
        }
        private int CalculateValueEatedMakro(int eatedGrams, int quantityInGrams)
        {
            double calculatedValue = (double)(eatedGrams / 100.0 * quantityInGrams);

            return (int)calculatedValue;
        }
    }
}
