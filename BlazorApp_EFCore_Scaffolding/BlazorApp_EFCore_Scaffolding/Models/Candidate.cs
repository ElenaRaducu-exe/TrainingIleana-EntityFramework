using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Candidate
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;
}
