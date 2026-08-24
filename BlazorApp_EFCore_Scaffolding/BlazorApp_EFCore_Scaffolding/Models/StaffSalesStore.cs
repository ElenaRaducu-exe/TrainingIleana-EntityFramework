using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class StaffSalesStore
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ContactStaff { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string AddressDetails { get; set; } = null!;

    public decimal? Amount { get; set; }
}
