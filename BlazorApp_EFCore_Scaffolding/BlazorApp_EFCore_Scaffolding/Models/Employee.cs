using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;
}
