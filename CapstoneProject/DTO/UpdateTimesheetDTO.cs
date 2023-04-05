namespace CapstoneProject.DTO
{
    public class UpdateTimesheetDTO
    {
        public int Tid { get; set; }
        public string? TimesheetId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? EmployeeId { get; set; }

        public string? ProjectId { get; set; }
        public string? Status { get; set; }
    }
}
