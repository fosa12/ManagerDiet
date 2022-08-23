using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.DeleteMeal
{
    public class DeleteMealCommand : IRequest
    {
        public int MealToDelteId { get; set; }
    }
}
