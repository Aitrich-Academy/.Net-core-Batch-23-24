using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Sale
{
    public string? Product { get; set; }

    public string? Region { get; set; }

    public long? Amount { get; set; }

    public int ProductId { get; set; }
}
