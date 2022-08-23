using ManagerDiet.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.DeleteMeal
{
    public class DeleteMealCommandHandler : IRequestHandler<DeleteMealCommand>
    {
        private readonly IDietDbContext _context;
        public DeleteMealCommandHandler(IDietDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteMealCommand request, CancellationToken cancellationToken)
        {
            var meal = await _context.Meals.Where(p => p.Id == request.MealToDelteId).FirstOrDefaultAsync(cancellationToken);

            _context.Meals.Remove(meal);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
