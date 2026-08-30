using Assignment_3.Models;
using Assignment_3.Repository;
using Assignment_3.Services;
using Assignment7.DTO;
using Microsoft.AspNetCore.Mvc;
namespace Assignment_3.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private ITaskServices tasks;

        

        public TaskController(ITaskServices tasks)
        {
            this.tasks = tasks;
        }
        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTaskRequest request)
        {
            var result = await tasks.CreateTask(request);

            return Ok(result);
        }

        [HttpGet]
        [Route(("{id}"))]

        public async Task<IActionResult> GetById(int id)
        {
            var getbyid = await tasks.GetTaskById(id);
            if(getbyid == null)
            {
                return NotFound();
            }
            return Ok(getbyid);
        }
    }
}
