using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbNews
{
    public int NewsId { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public string? Detail { get; set; }

    public string? Image { get; set; }

    public string? SeoTitle { get; set; }

    public string? SeoDescription { get; set; }

    public string? SeoKeywords { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual TbBlog News { get; set; } = null!;
}
