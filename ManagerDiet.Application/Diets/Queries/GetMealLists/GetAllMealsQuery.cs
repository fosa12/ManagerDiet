using ManagerDiet.Shared.Diets.Queries.GetMealLists;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetMealLists
{
    public class GetAllMealsQuery : IRequest<List<MealForListVm>>
    {
    }
}
