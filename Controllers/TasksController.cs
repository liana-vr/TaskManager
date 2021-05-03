
using Microsoft.AspNetCore.Mvc;
using Tasks.Data;

namespace Tasks.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private ITaskService _service;
        public TasksController(ITaskService service)
        {
            this._service = service;
        }

        [HttpGet("[action]")]
        public IActionResult GetTasks()
        {
            var allTasks = _service.GetAllTasks();
            return Ok(allTasks);
        }

        [HttpGet("SingleTask/{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = _service.GetTaskById(id);
            return Ok(task);
        }


        [HttpPost("AddTask")]
        public IActionResult AddTask([FromBody]Task task)
        {
            if(task != null)
            {
                _service.AddTask(task);
            }
            return Ok();
        }

        [HttpPut("UpdateTask/{id}")]
        public IActionResult UpdateTask(int id, [FromBody]Task task)
        {
            _service.UpdateTask(id, task);
            return Ok(task);
        }

        [HttpDelete("DeleteTask/{id}")]
        public IActionResult DeleteTask(int id)
        {
            _service.DeleteTask(id);
            return Ok();
        }

    }
}