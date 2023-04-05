using System;
using System.Collections.Generic;

namespace CapstoneProject.Models;

public partial class Employee
{
    public int Eid { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public long? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? Department { get; set; }

    public string? ProjectId { get; set; }
}
