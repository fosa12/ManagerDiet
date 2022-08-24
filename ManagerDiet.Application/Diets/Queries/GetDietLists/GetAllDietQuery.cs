using ManagerDiet.Shared.Diets.Queries.GetDietLists;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetDietLists
{
    public class GetAllDietQuery : IRequest<List<DietForListVm>>
    {

    }
}
