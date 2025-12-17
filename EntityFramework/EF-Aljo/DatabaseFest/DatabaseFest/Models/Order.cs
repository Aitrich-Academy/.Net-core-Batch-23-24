using System;
using System.Collections.Generic;

namespace DatabaseFest.Models;

public partial class Order
{
    public int? Orderid { get; set; }

    public int Customerid { get; set; }

    public long? Amount { get; set; }
}
