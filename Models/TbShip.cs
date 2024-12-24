using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbShip
{
    public int ShippingId { get; set; }

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Adress { get; set; }

    public int? OrderDetailId { get; set; }

    public virtual TbOrderDetail? TbOrderDetail { get; set; }
}
