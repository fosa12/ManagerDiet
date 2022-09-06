using ManagerDiet.Shared.Diets.Queries.GetEatedMealForIndex;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetEatedMealForIndex
{
    public class GetEatedMealForIndexQuery : IRequest<EatedMealForIndexVm>
    {
        public int UserId { get; set; }
        public DateTime DateDayInDiet { get; set; }
    }
}
