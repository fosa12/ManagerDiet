using ManagerDiet.Application.Diets.Commands.CreateCaloricDemand;
using ManagerDiet.Application.Diets.Commands.CreateDiet;
using ManagerDiet.Application.Diets.Queries.GetCaloricDemand;
using ManagerDiet.Application.Diets.Queries.GetDietLists;
using ManagerDiet.Application.Diets.Queries.GetDietsDetail;
using ManagerDiet.Shared.Diets.Queries.GetCaloricDemand;
using ManagerDiet.Shared.Diets.Queries.GetDietDetail;
using ManagerDiet.Shared.Diets.Queries.GetDietLists;
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
        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateDietCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<List<DietForListVm>>> GetAsync()
        {
            var vm = await Mediator.Send(new GetAllDietQuery());

            return vm;
        }
        [HttpPost("caloricDemand")]
        public async Task<IActionResult> PostAsync(CreateCaloricDemandCommand command)
        {
            var result = await Mediator.Send(command);

            return Ok(result);
        }
        [HttpGet("caloricDemand/{userId}")]
        public async Task<ActionResult<CaloricDemandVm>> GetAsyncCaloricDemand(int userId)
        {
            var vm = await Mediator.Send(new GetCaloricDemandQuery() { UserId = userId });

            return vm;
        }
    }
}
