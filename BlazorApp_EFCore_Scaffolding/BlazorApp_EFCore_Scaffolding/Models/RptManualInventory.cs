using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class RptManualInventory
{
    public string? Made { get; set; }

    public string? Model { get; set; }

    public string? PartNumber { get; set; }

    public int? InitialStock { get; set; }

    public int? ModifiedQuantityRandomly { get; set; }

    public int? RemainingStock { get; set; }
}
