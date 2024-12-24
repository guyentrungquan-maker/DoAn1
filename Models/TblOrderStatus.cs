using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TblOrderStatus
{
    public int OrderStatusId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual TbOrder OrderStatus { get; set; } = null!;
}
