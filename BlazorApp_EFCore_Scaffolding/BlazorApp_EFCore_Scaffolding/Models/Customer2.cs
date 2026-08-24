using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Customer2
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public int? AddressId { get; set; }

    public virtual Address1? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
