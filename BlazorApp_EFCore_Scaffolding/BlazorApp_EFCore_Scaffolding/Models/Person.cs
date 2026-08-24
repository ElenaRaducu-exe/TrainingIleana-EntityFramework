using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? Dob { get; set; }

    public string FullName { get; set; } = null!;

    public string FullNamePersisted { get; set; } = null!;

    public int? AgeInYears { get; set; }
}
