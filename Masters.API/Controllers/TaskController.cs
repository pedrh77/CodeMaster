using Masters.DOMAIN.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Masters.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private ITaskService _taskService;
        private readonly ILogger _logger;


        public TaskController(ITaskService taskService, ILogger logger)
        {
            _taskService = taskService;
            _logger = logger;
        }

        [HttpGet("/Get/Operation")]
        public async Task<IActionResult> TaskGetOperation()
        {
            _logger.LogDebug("[/Get/Operation] Interation");
            var responseGetOpration = await _taskService.TaskGetOperation();
            return Ok(responseGetOpration);
        }

        [HttpGet("/Execute/Operation")]
        public async Task<IActionResult> TaskGetOperationCalculate()
        {
            await _taskService.TaskGetOperationCalculate();
            return Ok();

        }

    }
}
