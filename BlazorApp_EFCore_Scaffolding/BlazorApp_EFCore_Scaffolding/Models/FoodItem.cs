using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class FoodItem
{
    public int FoodItemId { get; set; }

    public string FoodName { get; set; } = null!;

    public decimal Grams { get; set; }

    public decimal Kcal { get; set; }

    public decimal PriceFoodItem { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
