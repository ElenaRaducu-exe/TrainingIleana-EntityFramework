using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? Category { get; set; }

    public int RestaurantId { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    public virtual Restaurant Restaurant { get; set; } = null!;
}
