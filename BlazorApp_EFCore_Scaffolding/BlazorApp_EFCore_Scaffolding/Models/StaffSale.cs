using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class StaffSale
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? Year { get; set; }

    public string ContactStaff { get; set; } = null!;

    public decimal? Amount { get; set; }
}
