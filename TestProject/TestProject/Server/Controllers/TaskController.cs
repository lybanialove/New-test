using Microsoft.AspNetCore.Mvc;
using TestProject.Shared.Database;
using TestProject.Shared.Entitys;

namespace TestProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private readonly ITask itask;
        public TaskController(ILogger<TaskController> logger, ITask _itask)
        {
            _logger = logger;
            itask = _itask;
        }

        [HttpGet]
        public async Task<List<Task_>> Get()
        {
            return await Task.FromResult(itask.GetTaskDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Task_ task = itask.GetTaskData(id);
            if (task != null)
            {
                return Ok(task);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Task_ task)
        {
            itask.AddTask(task);
        }
        [HttpPut]
        public void Put(Task_ task)
        {
            itask.UpdateTaskDetails(task);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            itask.DeleteTask(id);
            return Ok();
        }
    }
}
