using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class Orderr
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public string OrderNumber { get; set; } = null!;

    public string StatusOrder { get; set; } = null!;

    public int CustomerId { get; set; }

    public int RestaurantId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<OrderPayment> OrderPayments { get; set; } = new List<OrderPayment>();

    public virtual ICollection<OrderStatusAudit> OrderStatusAudits { get; set; } = new List<OrderStatusAudit>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual Restaurant Restaurant { get; set; } = null!;
}
