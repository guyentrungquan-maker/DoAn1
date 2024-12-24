using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbOrder
{
    public int OrderId { get; set; }

    public string? Code { get; set; }

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? TotalAmount { get; set; }

    public int? Quanlity { get; set; }

    public int? OrderStatusId { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int? WishListId { get; set; }

    public virtual TbWishList Order { get; set; } = null!;

    public virtual TbOrderDetail? TbOrderDetail { get; set; }

    public virtual TblOrderStatus? TblOrderStatus { get; set; }
}
