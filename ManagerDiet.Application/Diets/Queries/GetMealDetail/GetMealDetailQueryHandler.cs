using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Queries.GetMealDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetMealDetail
{
    public class GetMealDetailQueryHandler : IRequestHandler<GetMealDetailQuery, MealDetailVm>
    {
        private readonly IDietDbContext _context;
        public GetMealDetailQueryHandler(IDietDbContext dietDbContext)
        {
            _context = dietDbContext;
        }
        public async Task<MealDetailVm> Handle(GetMealDetailQuery request, CancellationToken cancellationToken)
        {
            var mealVm = await _context.Meals.Where(p => p.Id == request.MealId).Include(x => x.Ingredients).FirstOrDefaultAsync(cancellationToken);




            return MapMealDetail(mealVm);
        }

        private MealDetailVm MapMealDetail(Meal mealVm)
        {
            var ingredientsToShow = new List<IngredientToMealDetailVm>();
            foreach (var item in mealVm.Ingredients)
            {
                IngredientToMealDetailVm ingredientToMealDetailVm = new IngredientToMealDetailVm()
                {
                    Name = item.Name,
                };
                ingredientsToShow.Add(ingredientToMealDetailVm);
            }

            var result = new MealDetailVm()
            {
                Name = mealVm.Name,
                Recipe = mealVm.Recipe,
                PreparationTimeInMin = mealVm.PreparationTimeInMin,
                GlycemicIndex = mealVm.GlycemicIndex,
                QuantityProteinInGrams = mealVm.QuantityProteinInGrams,
                QuantityCarboInGrams = mealVm.QuantityCarboInGrams,
                QuantitySaturatedFatInGrams = mealVm.QuantitySaturatedFatInGrams,
                QuantityFatInGrams = mealVm.QuantityFatInGrams,
                QuantitySugar = mealVm.QuantitySugar,
                Ingredients = ingredientsToShow,
                KCAL = mealVm.KCAL
            };
            return result;
        }
    }
}
