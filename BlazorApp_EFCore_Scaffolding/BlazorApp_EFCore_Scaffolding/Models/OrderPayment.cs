using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class OrderPayment
{
    public int OrderPaymentId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string StatusPayment { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public DateTime PaymentDate { get; set; }

    public int OrderId { get; set; }

    public virtual Orderr Order { get; set; } = null!;
}
