using ManagerDiet.Shared.Meals.Queries.GetEatedMealsByDate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Meals.Queries.GetEatedMealLists
{
    public class GetEatedMealListQuery : IRequest<EatedMealsVm>
    {
        public int UserId { get; set; }
        public DateTime DateDayInDiet { get; set; }
    }
}
