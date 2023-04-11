using System;
using System.Collections.Generic;

namespace CapstoneProject.Models;

public partial class Blog
{
    public int Bid { get; set; }

    public string? BlogTitle { get; set; }

    public string? BlogDescription { get; set; }

    public string? BlogImage { get; set; }

    public string? BlogLink { get; set; }
}
