using System;
using System.Collections.Generic;

namespace CapstoneProject.Models;

public partial class Timesheet
{
    public int Tid { get; set; }

    public string? TimesheetId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? EmployeeId { get; set; }

    public string? ProjectId { get; set; }

    public string? Status { get; set; }
}
