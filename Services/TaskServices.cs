using Assignment_3.Models;
using Assignment_3.Repository;
using Assignment7.DTO;
using AutoMapper;
namespace Assignment_3.Services
{
    public class TaskServices : ITaskServices
    {
 

        private ITaskRepository _repo;
        private IMapper _mapper;
        
        public TaskServices(ITaskRepository repository, IMapper mapper)
        {
           _repo = repository;
            _mapper = mapper;
        }

        public async Task<TaskItemDto> CreateTask(CreateTaskRequest request)
        {
            var tasks = _mapper.Map<Tasks>(request);
            await _repo.AddAsync(tasks);

            await _repo.SaveChangesAsync();

            return _mapper.Map<TaskItemDto>(tasks);
        }

     
        public Task<IEnumerable<TaskItemDto>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public async Task<TaskItemDto?> GetTaskById(int id)
        {
            var task = await _repo.GetByIdAsync(id);
            if (task == null) {
                return null;

                
            }

            return _mapper.Map<TaskItemDto>(task);
        }

        public Task<bool> UpdateTask(int id, UpdateTaskRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
