namespace EmployeeInfo.Shared
{
    public class PTORequest
    {
        public int Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool isApproved { get; set; } = false;
        public bool isVacationTime { get; set; } = true;
        public bool hasWeekendTime { get; set; } = false;
    }
}
