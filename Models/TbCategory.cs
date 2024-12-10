using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbCategory
{
    public int? CategoryId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

   



    public virtual TbBlog? TbBlog { get; set; }
    public bool? IsActive { get; set; }
}
