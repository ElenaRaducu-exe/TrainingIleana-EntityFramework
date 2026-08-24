using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Address1
{
    public int AddressId { get; set; }

    public string Street { get; set; } = null!;

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public virtual ICollection<Customer2> Customer2s { get; set; } = new List<Customer2>();

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
