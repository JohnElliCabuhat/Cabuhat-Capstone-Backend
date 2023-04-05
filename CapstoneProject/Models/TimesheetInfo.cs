namespace CapstoneProject.Models
{
    public class TimesheetInfo
    {
        public int Tid { get; set; }
        public string? TimesheetId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? EmployeeName { get; set; }

        public string? ProjectName { get; set; }

        public string? Status { get; set; }
    }
}
