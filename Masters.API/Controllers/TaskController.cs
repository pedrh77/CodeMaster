using Masters.DOMAIN.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Masters.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class TaskController : ControllerBase
    {
        public ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> TaskGetOperationCalculate()
        {
            await _taskService.TaskGetOperationCalculate();
            return Ok();

        }

    }
}
