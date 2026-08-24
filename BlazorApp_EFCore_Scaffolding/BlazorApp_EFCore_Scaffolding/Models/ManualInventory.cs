using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class ManualInventory
{
    public string? Made { get; set; }

    public string? Model { get; set; }

    public string? PartNumber { get; set; }

    public int? InitialStock { get; set; }

    public int? Counted { get; set; }

    public int? RemainingStock { get; set; }

    public decimal? CountedPercent { get; set; }
}
