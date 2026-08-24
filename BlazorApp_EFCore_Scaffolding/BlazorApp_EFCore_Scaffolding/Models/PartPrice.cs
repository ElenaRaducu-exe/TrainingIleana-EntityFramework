using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class PartPrice
{
    public int PartId { get; set; }

    public DateOnly ValidFrom { get; set; }

    public decimal Price { get; set; }
}
