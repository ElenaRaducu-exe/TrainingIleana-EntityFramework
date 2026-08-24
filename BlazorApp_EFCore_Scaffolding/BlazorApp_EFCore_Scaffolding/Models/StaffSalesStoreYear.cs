using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class StaffSalesStoreYear
{
    public string StoreName { get; set; } = null!;

    public string AddressDetails { get; set; } = null!;

    public int? Year { get; set; }

    public decimal? Amount { get; set; }
}
