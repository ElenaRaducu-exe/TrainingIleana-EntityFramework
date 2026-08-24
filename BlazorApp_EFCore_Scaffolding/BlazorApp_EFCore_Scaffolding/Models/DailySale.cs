using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class DailySale
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Day { get; set; }

    public string CustomerName { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? Sales { get; set; }
}
