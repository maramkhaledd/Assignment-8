using System.ComponentModel.DataAnnotations;

namespace Assignment7.DTO
{
    public class CreateTaskRequest
    {
        
        public string Title { get; set; }

        public int Priority { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
