using Assignment_3.Models;
using Assignment_3.Middleware;
using Assignment6.Data;
using Microsoft.EntityFrameworkCore;
namespace Assignment_3.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Tasks task)
        {
            await _context.Tasks.AddAsync(task);
        }

        public void DeleteTasks(Tasks task)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tasks>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Tasks?> GetByIdAsync(int id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }

      
    }
}
