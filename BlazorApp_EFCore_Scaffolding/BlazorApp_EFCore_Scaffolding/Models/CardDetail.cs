using System;
using System.Collections.Generic;

namespace BlazorApp_EFCore_Scaffolding.Models;

public partial class CardDetail
{
    public int CardDetailsId { get; set; }

    public int CustomerId { get; set; }

    public string CardNumber { get; set; } = null!;

    public string CardHolderName { get; set; } = null!;

    public byte ExpiryDateMonth { get; set; }

    public short ExpiryDateYear { get; set; }

    public string Cvv { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
