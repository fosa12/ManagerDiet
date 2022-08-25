using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using ManagerDiet.Shared.Diets.Queries.GetDietLists;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Queries.GetDietLists
{
    public class GetAllDietQueryHandler : IRequestHandler<GetAllDietQuery, List<DietForListVm>>
    {
        private readonly IDietDbContext _context;
        public GetAllDietQueryHandler(IDietDbContext context)
        {
            _context = context;
        }

        public async Task<List<DietForListVm>> Handle(GetAllDietQuery request, CancellationToken cancellationToken)
        {
            var diets = await _context.Diets.Where(p => p.StatusId == 1).ToListAsync();

            return MapDietsToVm(diets);
        }

        private List<DietForListVm> MapDietsToVm(List<Diet> diets)
        {
            List<DietForListVm> dietForListVms = new List<DietForListVm>();
            foreach (var diet in diets)
            {
                DietForListVm dietForListVm = new DietForListVm()
                {
                    Id = diet.Id,
                    DietName = diet.DietName,
                    DietShortDescryption = diet.DietShortDescryption,
                    GlycemicIndex = diet.GlycemicIndex,
                    QuantityCarbo = diet.QuantityCarbo,
                    QuantityFat = diet.QuantityFat,
                    QuantityProtein = diet.QuantityProtein
                };
                dietForListVms.Add(dietForListVm);
            };

            return dietForListVms;
        }
    }
}
