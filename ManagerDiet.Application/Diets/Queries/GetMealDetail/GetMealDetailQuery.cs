using ManagerDiet.Shared.Diets.Queries.GetMealDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetMealDetail
{
    public class GetMealDetailQuery : IRequest<MealDetailVm>
    {
        public int MealId { get; set; }
    }
}

