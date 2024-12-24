using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbProductReview
{
    public int ProductReviewld { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? Detail { get; set; }

    public int? Star { get; set; }

    public int? Productld { get; set; }

    public bool? IsActive { get; set; }

    public virtual TbProduct ProductReviewldNavigation { get; set; } = null!;
}
