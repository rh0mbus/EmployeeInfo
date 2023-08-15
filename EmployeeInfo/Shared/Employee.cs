namespace EmployeeInfo.Shared
{
    public class Employee
    {
        public int Id { get; set; }
        public int ManagerEmployeeId { get; set; } = -1;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CompanyPhone { get; set; } = string.Empty;
        public float VacationHours { get; set; } = 0.0f;
        public float SickHours { get; set; } = 0.0f;
        public string Title { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public Team Team { get; set; } 
        public DateTime HireDate { get; set; }
        public EmployeeType Type { get; set; }
        public Salary Salary { get; set; }
        public List<TodoTask> EmployeeTasks { get; set; } = new List<TodoTask>();
        public List<PTORequest> PTORequests{ get; set; } = new List<PTORequest>();

        public Employee()
        {
            Team = new Team();
            Salary = new Salary();
        }
    }
}
