
using ManagerDiet.Application.Diets.Queries.GetDietsDetail;
using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Queries.GetDietDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetDietDetail
{
    public class GetDietDetailQueryHandler : IRequestHandler<GetDietDetailQuery, DietDetailVm>
    {
        private readonly IDietDbContext _context;
        public GetDietDetailQueryHandler(IDietDbContext dietDbContext)
        {
            _context = dietDbContext;
        }
        public async Task<DietDetailVm> Handle(GetDietDetailQuery request, CancellationToken cancellationToken)
        {
            var diet = await _context.Diets.Where(p => p.Id == request.DietId).FirstOrDefaultAsync(cancellationToken);




            return MapDietDetailVm(diet);
        }
        private DietDetailVm MapDietDetailVm(Diet diet)
        {
            if (diet != null)
            {
                var dietVm = new DietDetailVm()
                {
                    DietName = diet.DietName,
                    DietShortDescryption = diet.DietShortDescryption,
                    DietDescryption = diet.DietDescryption,
                    GlycemicIndex = diet.GlycemicIndex,
                    QuantityProtein = diet.QuantityProtein,
                    QuantityCarbo = diet.QuantityCarbo,
                    QuantityFat = diet.QuantityFat
                };
                return dietVm;
            }
            return null;

        }
    }
}