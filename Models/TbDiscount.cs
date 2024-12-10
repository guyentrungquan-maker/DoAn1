using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbDiscount
{
    public string DiscountId { get; set; } = null!;

    public string? DiscountAmount { get; set; }

    public string? Vat { get; set; }

    public string? Quanlity { get; set; }

    public string? TotalAmount { get; set; }

    public virtual TbPaymentMethod? TbPaymentMethod { get; set; }
}
