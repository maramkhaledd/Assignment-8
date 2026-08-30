
using Assignment_3.Models;
namespace Assignment_3.Repository
{
    public interface ITaskRepository
    {
 

        Task <IEnumerable<Tasks>> GetAllAsync();

        Task<Tasks?> GetByIdAsync(int id);

        Task AddAsync(Tasks task);

        Task SaveChangesAsync();

        
    }
}
