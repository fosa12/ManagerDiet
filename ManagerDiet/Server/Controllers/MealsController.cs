using ManagerDiet.Application.Diets.Commands.CreateMeal;
using ManagerDiet.Application.Diets.Commands.DeleteMeal;
using ManagerDiet.Application.Diets.Queries.GetEatedMealForIndex;
using ManagerDiet.Application.Diets.Queries.GetMealDetail;
using ManagerDiet.Application.Diets.Queries.GetMealLists;
using ManagerDiet.Application.Meals.Queries.GetEatedMealLists;
using ManagerDiet.Shared.Diets.Commands;
using ManagerDiet.Shared.Diets.Queries.GetEatedMealForIndex;
using ManagerDiet.Shared.Diets.Queries.GetMealDetail;
using ManagerDiet.Shared.Diets.Queries.GetMealLists;
using ManagerDiet.Shared.Meals.Queries.GetEatedMealsByDate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagerDiet.Server.Controllers
{
    [Route("api/meals")]
    public class MealsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<MealForListVm>>> GetAsync()
        {
            var vm = await Mediator.Send(new GetAllMealsQuery());

            return vm;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<MealDetailVm>> GetAsync(int id)
        {
            var vm = await Mediator.Send(new GetMealDetailQuery() { MealId = id });
            
            return vm;
        }
        [HttpPost]
        public async Task<ActionResult<int>> PostAsync(CreateMealVm meal)
        {
            var id = await Mediator.Send(new CreateMealCommand { Meal = meal });
            return id;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await Mediator.Send(new DeleteMealCommand() { MealToDelteId = id });
            return Ok();
        }
        [HttpGet("{id}/{date}")]
        public async Task<ActionResult<EatedMealForIndexVm>> GetAsync(int id, DateTime date)
        {
            var vm = await Mediator.Send(new GetEatedMealForIndexQuery() {UserId = id, DateDayInDiet= date });

            return vm;
        }
        [HttpGet("eatedMeals/{id}/{date}")]
        public async Task<ActionResult<EatedMealsVm>> GetEatedMealsAsync(int id, DateTime date)
        {
            var vm = await Mediator.Send(new GetEatedMealListQuery() { UserId = id, DateDayInDiet = date });

            return vm;
        }
    }
}

