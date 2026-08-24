using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class InvMiniInventory
{
    public int IdInventory { get; set; }

    public string? Warehouse { get; set; }

    public string? Project { get; set; }

    public string? Store { get; set; }

    public string? Location { get; set; }

    public string? Made { get; set; }

    public string? Model { get; set; }

    public string? PartNumber { get; set; }

    public string? PalletNr { get; set; }

    public int? Quantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public string? ModifiedBy { get; set; }
}
