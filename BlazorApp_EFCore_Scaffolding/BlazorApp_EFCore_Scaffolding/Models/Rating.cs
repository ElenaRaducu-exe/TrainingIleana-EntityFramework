using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public byte? RestaurantRating { get; set; }

    public byte? DeliveryStaffRating { get; set; }

    public int OrderId { get; set; }

    public virtual Orderr Order { get; set; } = null!;
}
