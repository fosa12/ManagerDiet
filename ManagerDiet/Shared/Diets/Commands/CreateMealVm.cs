using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Diets.Commands
{
    public class CreateMealVm
    {
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int PreparationTimeInMin { get; set; }
        public string GlycemicIndex { get; set; }
        public int QuantityProteinInGrams { get; set; }
        public int QuantityCarboInGrams { get; set; }
        public double QuantitySugar { get; set; }
        public int QuantityFatInGrams { get; set; }
        public double QuantitySaturatedFatInGrams { get; set; }
        public string Ingredients { get; set; }
        public int KCAL { get; set; }
    }

    public class AddMealValidator : AbstractValidator<CreateMealVm>
    {
        public AddMealValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Recipe).NotEmpty();
            RuleFor(c => c.PreparationTimeInMin).NotEqual(0).NotEmpty().NotNull();
            RuleFor(c => c.GlycemicIndex).NotEmpty();
            RuleFor(c => c.QuantityProteinInGrams).NotEqual(0).NotEmpty().NotNull();
            RuleFor(c => c.QuantityCarboInGrams).NotEqual(0).NotEmpty().NotNull();
            RuleFor(c => c.QuantityFatInGrams).NotEqual(0).NotEmpty().NotNull();
            RuleFor(c => c.Ingredients).NotEmpty();
            RuleFor(c => c.KCAL).NotEqual(0).NotEmpty().NotNull();

        }
    }
}
