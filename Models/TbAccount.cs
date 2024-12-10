using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbAccount
{
    public int? AccountId { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? LastLogin { get; set; }

    public string? IsActive { get; set; }

    public string? ShippingId { get; set; }

    public string? PaymentId { get; set; }

    public virtual TbBlog Account { get; set; } = null!;
}
