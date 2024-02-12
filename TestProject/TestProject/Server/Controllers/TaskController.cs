using Microsoft.AspNetCore.Mvc;

namespace TestProject.Server.Controllers
{
    [ApiController]
    [Route("[TaskController]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }


    }
}
