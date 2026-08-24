using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class RptManualInventoryQuantityDiferenceProject
{
    public string? Project { get; set; }

    public int? InitialStock { get; set; }

    public int? ModifiedQuantity { get; set; }

    public int? RemainingStock { get; set; }

    public int? NumberItemsProject { get; set; }
}
