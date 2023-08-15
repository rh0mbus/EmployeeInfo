namespace EmployeeInfo.Shared
{
    public class TodoTask
    {
        public int Id { get; set; }
        
        public TaskType Type { get; set; }
        
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime AssignmentDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool isTrainingTask { get; set; }

        public bool isCompleted { get; set; } = false;  
    }
}
