using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbOrder
{
    public string OrderId { get; set; } = null!;

    public string? Code { get; set; }

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? TotalAmount { get; set; }

    public string? Quanlity { get; set; }

    public string? OrderStatusId { get; set; }

    public string? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? WishListId { get; set; }

    public virtual TbWishList Order { get; set; } = null!;

    public virtual TbOrderDetail? TbOrderDetail { get; set; }

    public virtual TblOrderStatus? TblOrderStatus { get; set; }
}
