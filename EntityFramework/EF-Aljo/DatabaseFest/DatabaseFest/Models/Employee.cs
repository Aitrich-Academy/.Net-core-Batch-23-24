using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string? Department { get; set; }

    public decimal? Salary { get; set; }
}
