using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbWishList
{
    public string WishListId { get; set; } = null!;

    public string? Quanlity { get; set; }

    public string? Amount { get; set; }

    public string? TotalAmount { get; set; }

    public virtual TbOrder? TbOrder { get; set; }
}
