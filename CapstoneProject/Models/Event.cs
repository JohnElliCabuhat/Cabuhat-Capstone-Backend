using System;
using System.Collections.Generic;

namespace CapstoneProject.Models;

public partial class Event
{
    public int Evid { get; set; }

    public string? EventName { get; set; }

    public string? EventDescription { get; set; }

    public string? EventImage { get; set; }
}
