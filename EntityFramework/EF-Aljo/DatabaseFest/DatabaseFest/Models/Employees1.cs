using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Employees1
{
    public int EmployeeId { get; set; }

    public string? Name { get; set; }

    public int? DepartmentId { get; set; }

    public string? JobTitle { get; set; }
}
