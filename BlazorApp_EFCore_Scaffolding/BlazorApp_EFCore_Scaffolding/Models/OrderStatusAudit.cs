using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class OrderStatusAudit
{
    public int AuditId { get; set; }

    public int OrderId { get; set; }

    public string? OldStatus { get; set; }

    public string NewStatus { get; set; } = null!;

    public DateTime StatusChangedAt { get; set; }

    public string Operation { get; set; } = null!;

    public virtual Orderr Order { get; set; } = null!;
}
