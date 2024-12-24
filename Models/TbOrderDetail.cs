using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbOrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? PaymentId { get; set; }

    public string? Price { get; set; }

    public int? Quantity { get; set; }

    public virtual TbOrder OrderDetail { get; set; } = null!;

    public virtual TbShip OrderDetailNavigation { get; set; } = null!;

    public virtual TbPaymentMethod? QuantityNavigation { get; set; }
}
