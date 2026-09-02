using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Customer1
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string FullName { get; set; } = null!;

    public bool? IsActive { get; set; }
}
