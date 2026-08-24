using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class ManualInventoryMade
{
    public string? Made { get; set; }

    public int? InitialStock { get; set; }

    public int? CountedTotal { get; set; }

    public int? RemainingStockTotal { get; set; }

    public decimal? CountedPercentTotal { get; set; }
}
