using System;
using System.Collections.Generic;

namespace CapstoneProject.Models;

public partial class Project
{
    public int Pid { get; set; }

    public string? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }
}
