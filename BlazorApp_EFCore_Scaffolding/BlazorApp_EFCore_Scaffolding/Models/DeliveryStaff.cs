using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class DeliveryStaff
{
    public int DeliveryStaffId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int DeliveryId { get; set; }

    public virtual Delivery Delivery { get; set; } = null!;
}
