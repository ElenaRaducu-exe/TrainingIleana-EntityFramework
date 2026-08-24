using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class CustomerPhone
{
    public int CustomerId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? PhoneType { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
