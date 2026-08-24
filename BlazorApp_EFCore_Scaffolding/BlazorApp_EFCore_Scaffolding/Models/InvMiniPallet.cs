using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class InvMiniPallet
{
    public int IdPallet { get; set; }

    public string? PalletNr { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public string? ModifiedBy { get; set; }
}
