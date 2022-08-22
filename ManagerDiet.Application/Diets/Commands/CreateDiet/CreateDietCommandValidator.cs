using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.CreateDiet
{
    public class CreateDietCommandValidator : AbstractValidator<CreateDietCommand>
    {
        public CreateDietCommandValidator()
        {
            RuleFor(p => p.DietName).NotEmpty().MaximumLength(50);
            RuleFor(p => p.DietShortDescryption).NotEmpty().MaximumLength(50);
            RuleFor(p => p.DietDescryption).NotEmpty().MaximumLength(5000);
            RuleFor(p => p.GlycemicIndex).NotEmpty();
            RuleFor(p => p.QuantityProtein).NotEmpty();
            RuleFor(p => p.QuantityCarbo).NotEmpty();
            RuleFor(p => p.QuantityFat).NotEmpty();
        }
    }
}
