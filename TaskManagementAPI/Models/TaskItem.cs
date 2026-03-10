namespace TaskManagementAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public int Priority { get; set; } = 1; // 1=low, 2=medium, 3=high
        public DateTime? duedate { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

        //foregin key
        public int userId { get; set; }

        //navigation property
        public User User { get; set; } = null!;
    }
}
