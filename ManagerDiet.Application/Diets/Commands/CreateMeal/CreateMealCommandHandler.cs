using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, int>
    {
        private readonly IDietDbContext _context;
        public CreateMealCommandHandler(IDietDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var meal = new Meal()
            {
                Name = request.Meal.Name,
                Recipe = request.Meal.Recipe,
                PreparationTimeInMin = request.Meal.PreparationTimeInMin,
                GlycemicIndex = request.Meal.GlycemicIndex,
                QuantityProteinInGrams = request.Meal.QuantityProteinInGrams,
                QuantityCarboInGrams = request.Meal.QuantityCarboInGrams,
                QuantitySugar = request.Meal.QuantitySugar,
                QuantityFatInGrams = request.Meal.QuantityFatInGrams,
                QuantitySaturatedFatInGrams = request.Meal.QuantitySaturatedFatInGrams,
                KCAL = request.Meal.KCAL,
            };

            _context.Meals.Add(meal);

            await _context.SaveChangesAsync(cancellationToken);

            var ingredients = request.Meal.Ingredients.Split(',');

            foreach (var ingredient in ingredients)
            {
                Ingredient ingredientToAdd = new Ingredient()
                {
                    MealId = meal.Id,
                    Name = ingredient,
                };
                _context.Ingredients.Add(ingredientToAdd);
            }
            await _context.SaveChangesAsync(cancellationToken);



            return meal.Id;
        }
    }
}

