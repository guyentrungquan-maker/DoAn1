using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbOrderDetail
{
    public string OrderDetailId { get; set; } = null!;

    public string? OrderId { get; set; }

    public string? ProductId { get; set; }

    public string? PaymentId { get; set; }

    public string? Price { get; set; }

    public string? Quantity { get; set; }

    public virtual TbOrder OrderDetail { get; set; } = null!;

    public virtual TbShip OrderDetailNavigation { get; set; } = null!;

    public virtual TbPaymentMethod? QuantityNavigation { get; set; }
}
