using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbShip
{
    public string ShippingId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Adress { get; set; }

    public string? OrderDetailId { get; set; }

    public virtual TbOrderDetail? TbOrderDetail { get; set; }
}
