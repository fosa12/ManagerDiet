using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Shared.Diets.Commands
{
    public class AddNewDietVM
    {
        public string DietName { get; set; }
        public string DietShortDescryption { get; set; }
        public string DietDescryption { get; set; }
        public string GlycemicIndex { get; set; }
        public string QuantityProtein { get; set; }
        public string QuantityCarbo { get; set; }
        public string QuantityFat { get; set; }

    }

    public class AddDietValidator : AbstractValidator<AddNewDietVM>
    {
        public AddDietValidator()
        {
            RuleFor(x => x.DietName).NotEmpty().WithMessage("Pole nie może być puste");
            RuleFor(x => x.DietName).MaximumLength(50).WithMessage("Maksymalna długość nazwy diety to 50 znaków");
            RuleFor(x => x.DietName).MinimumLength(10).WithMessage("Minimalna długość nazwy diety to 10 znaków");

            RuleFor(x => x.DietShortDescryption).NotEmpty().WithMessage("Pole nie może być puste");
            RuleFor(x => x.DietShortDescryption).MaximumLength(50).WithMessage("Maksymalna długość krótkiego opisu diety to 50 znaków");
            RuleFor(x => x.DietShortDescryption).MinimumLength(10).WithMessage("Minimalna długość krótkiego opisu diety 10 znaków");

            RuleFor(x => x.DietDescryption).NotEmpty().WithMessage("Pole nie może być puste");
            RuleFor(x => x.DietDescryption).MinimumLength(200).WithMessage("Minimalna długość opisu diety to 200 znaków");

            RuleFor(x => x.GlycemicIndex).NotEmpty().WithMessage("Wybierz odpowiednią wartość");

            RuleFor(x => x.QuantityProtein).NotEmpty().WithMessage("Wybierz odpowiednią wartość");

            RuleFor(x => x.QuantityCarbo).NotEmpty().WithMessage("Wybierz odpowiednią wartość");

            RuleFor(x => x.QuantityFat).NotEmpty().WithMessage("Wybierz odpowiednią wartość");
        }

    }
}

