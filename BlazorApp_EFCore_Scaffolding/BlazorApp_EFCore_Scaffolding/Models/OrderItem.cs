using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class OrderItem
{
    public int OrderId { get; set; }

    public int FoodItemId { get; set; }

    public int Quantity { get; set; }

    public decimal Discount { get; set; }

    public bool? Cutlery { get; set; }

    public int PackingCost { get; set; }

    public virtual FoodItem FoodItem { get; set; } = null!;

    public virtual Orderr Order { get; set; } = null!;
}
