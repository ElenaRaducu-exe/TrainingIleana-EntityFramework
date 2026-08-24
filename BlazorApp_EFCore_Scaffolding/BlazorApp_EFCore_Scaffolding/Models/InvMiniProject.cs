using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class InvMiniProject
{
    public int IdProject { get; set; }

    public string? Project { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public string? ModifiedBy { get; set; }
}
