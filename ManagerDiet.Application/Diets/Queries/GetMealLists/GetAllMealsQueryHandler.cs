using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Queries.GetDietDetail;
using ManagerDiet.Shared.Diets.Queries.GetMealLists;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetMealLists
{
    internal class GetAllMealsQueryHandler : IRequestHandler<GetAllMealsQuery, List<MealForListVm>>
    {
        private readonly IDietDbContext _context;
        public GetAllMealsQueryHandler(IDietDbContext dietDbContext)
        {
            _context = dietDbContext;
        }

        public async Task<List<MealForListVm>> Handle(GetAllMealsQuery request, CancellationToken cancellationToken)
        {
            var meals = await _context.Meals.Where(p => p.StatusId == 1).ToListAsync();

            return MapMealslVm(meals);
        }

        private List<MealForListVm> MapMealslVm(List<Meal> meals)
        {
            if (meals != null)
            {
                var result = new List<MealForListVm>();
                foreach (var meal in meals)
                {
                    var mealVm = new MealForListVm()
                    {
                        Name = meal.Name,
                        PreparationTimeInMin = meal.PreparationTimeInMin,
                        GlycemicIndex = meal.GlycemicIndex,
                        QuantityProteinInGrams = meal.QuantityProteinInGrams,
                        QuantityCarboInGrams = meal.QuantityCarboInGrams,
                        QuantityFatInGrams = meal.QuantityFatInGrams,
                    };
                    result.Add(mealVm);
                }
                return result;
            }
            return null;

        }
    }
}
