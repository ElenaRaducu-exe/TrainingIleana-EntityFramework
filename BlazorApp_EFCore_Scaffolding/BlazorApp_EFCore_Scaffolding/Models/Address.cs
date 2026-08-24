using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string? Street { get; set; }

    public string? StreetNumber { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public string? BuildingName { get; set; }

    public string? Entrace { get; set; }

    public int? FloorNumber { get; set; }

    public int? Apartment { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
