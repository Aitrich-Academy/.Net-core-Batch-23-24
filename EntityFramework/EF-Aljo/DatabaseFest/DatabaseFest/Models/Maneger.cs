using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Maneger
{
    public int? Employeeid { get; set; }

    public string? Name { get; set; }

    public int? Manegerid { get; set; }

    public int? Departmentid { get; set; }
}
