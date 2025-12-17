using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Customer1
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Username { get; set; }
}
