using ManagerDiet.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.DeleteDiet
{
    public class DeleteDietCommandHandler : IRequestHandler<DeleteDietCommand>
    {
        private readonly IDietDbContext _context;
        public DeleteDietCommandHandler(IDietDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteDietCommand request, CancellationToken cancellationToken)
        {
            var diet = await _context.Diets.Where(p => p.Id == request.DietIdToDelete).FirstOrDefaultAsync(cancellationToken);

            _context.Diets.Remove(diet);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
