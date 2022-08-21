using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.CreateDiet
{
    public class CreateDietCommandHandler : IRequestHandler<CreateDietCommand, int>
    {
        private readonly IDietDbContext _context;
        public CreateDietCommandHandler(IDietDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateDietCommand request, CancellationToken cancellationToken)
        {
            Diet diet = new()
            {
                DietName = request.DietName,
                DietShortDescryption = request.DietShortDescryption,
                DietDescryption = request.DietDescryption,
                GlycemicIndex = request.GlycemicIndex,
                QuantityCarbo = request.QuantityCarbo,
                QuantityFat = request.QuantityFat,
                QuantityProtein = request.QuantityProtein,
            };

            _context.Diets.Add(diet);

            await _context.SaveChangesAsync(cancellationToken);

            return diet.Id;
        }
    }
}
