using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Price { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public bool? IsBestSeller { get; set; }

    public int? UnitlnStock { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsNew { get; set; }

    public bool? IsSale { get; set; }

    public virtual TbProductCategory? TbProductCategory { get; set; }

    public virtual TbProductReview? TbProductReview { get; set; }
}
