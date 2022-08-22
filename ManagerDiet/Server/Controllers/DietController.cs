using ManagerDiet.Application.Diets.Commands.CreateDiet;
using ManagerDiet.Application.Diets.Queries.GetDietsDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagerDiet.Server.Controllers
{
    [Route("api/diet")]
    public class DietController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<DietDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetDietDetailQuery() { DietId = id });

            return vm;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateDiet(CreateDietCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
