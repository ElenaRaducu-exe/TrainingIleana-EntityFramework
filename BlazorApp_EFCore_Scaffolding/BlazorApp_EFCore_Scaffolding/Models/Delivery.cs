using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Delivery
{
    public int DeliveryId { get; set; }

    public DateTime? ScheduledDelivery { get; set; }

    public string? StatusDelivery { get; set; }

    public int OrderId { get; set; }

    public virtual ICollection<DeliveryStaff> DeliveryStaffs { get; set; } = new List<DeliveryStaff>();

    public virtual Orderr Order { get; set; } = null!;
}
