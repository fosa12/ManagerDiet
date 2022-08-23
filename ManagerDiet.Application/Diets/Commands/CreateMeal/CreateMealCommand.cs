using ManagerDiet.Shared.Diets.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.CreateMeal
{
    public class CreateMealCommand : IRequest<int>
    {
        public CreateMealVm Meal { get; set; }
    }
}
