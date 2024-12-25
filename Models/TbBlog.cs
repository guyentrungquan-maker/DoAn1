using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Models;

public partial class TbBlog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BlogId { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public string? Detail { get; set; }

    public string? Image { get; set; }

    public string? SeoTitle { get; set; }

    public string? SeoDescription { get; set; }

    public string? SeoKeywords { get; set; }

    public string? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int? AccountId { get; set; }

    public bool? IsActive { get; set; }

    public virtual TbCategory? Category { get; set; }

    public virtual TbAccount? TbAccount { get; set; }

    public virtual TbNews? TbNews { get; set; }
}
