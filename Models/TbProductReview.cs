using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbProductReview
{
    public int? ProductReviewld { get; set; } = null!;

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? CreatedDate { get; set; }

    public string? Detail { get; set; }

    public string? Star { get; set; }

    public string? Productld { get; set; }

    public string? IsActive { get; set; }

    public virtual TbProduct ProductReviewldNavigation { get; set; } = null!;
}
