using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbWishList
{
    public int WishListId { get; set; }

    public int? Quanlity { get; set; }

    public string? Amount { get; set; }

    public string? TotalAmount { get; set; }

    public virtual TbOrder? TbOrder { get; set; }
}
