using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Employe
{
    public int? EmpId { get; set; }

    public string? EmpName { get; set; }

    public int? ManagerId { get; set; }
}
