using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbDiscount
{
    public int DiscountId { get; set; }

    public string? DiscountAmount { get; set; }

    public string? Vat { get; set; }

    public int? Quanlity { get; set; }

    public string? TotalAmount { get; set; }

    public virtual TbPaymentMethod? TbPaymentMethod { get; set; }
}
