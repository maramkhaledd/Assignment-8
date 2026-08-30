using Assignment_3.Models;
using Assignment7.DTO;
namespace Assignment_3.Services
{
    public interface ITaskServices
    {
        Task<IEnumerable<TaskItemDto>> GetAllTasks();
    
        Task<TaskItemDto?> GetTaskById(int id);
        Task<TaskItemDto> CreateTask(CreateTaskRequest request);
        Task<bool> UpdateTask(int id, UpdateTaskRequest request);
  
    }
}
