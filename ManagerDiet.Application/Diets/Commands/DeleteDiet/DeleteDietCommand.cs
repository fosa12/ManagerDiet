using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Diets.Commands.DeleteDiet
{
    public class DeleteDietCommand : IRequest
    {
        public int DietIdToDelete { get; set; }
    }
}
