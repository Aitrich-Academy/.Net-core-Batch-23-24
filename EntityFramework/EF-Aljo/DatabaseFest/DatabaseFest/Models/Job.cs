using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Job
{
    public int? Employeeid { get; set; }

    public string? Name { get; set; }

    public string? Jobtitle { get; set; }
}
