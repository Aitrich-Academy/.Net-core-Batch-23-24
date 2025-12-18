using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Sales1
{
    public int SaleId { get; set; }

    public string? ProductName { get; set; }

    public string? Category { get; set; }

    public int? Quantity { get; set; }

    public decimal? PricePerUnit { get; set; }

    public DateOnly? SaleDate { get; set; }
}
