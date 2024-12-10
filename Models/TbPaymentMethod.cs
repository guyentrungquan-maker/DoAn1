using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbPaymentMethod
{
    public string PaymentId { get; set; } = null!;

    public string? PaymentMethod { get; set; }

    public string? Amount { get; set; }

    public string? Vat { get; set; }

    public string? DiscountId { get; set; }

    public string? TotalAmount { get; set; }

    public virtual TbDiscount Payment { get; set; } = null!;

    public virtual ICollection<TbOrderDetail> TbOrderDetails { get; set; } = new List<TbOrderDetail>();
}
