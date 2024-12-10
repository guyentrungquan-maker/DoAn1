using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TblOrderStatus
{
    public string OrderStatusId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual TbOrder OrderStatus { get; set; } = null!;
}
