using ManagerDiet.Shared.Diets.Queries.GetDietDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetDietsDetail
{
    public class GetDietDetailQuery : IRequest<DietDetailVm>
    {
        public int DietId { get; set; }
    }
}
