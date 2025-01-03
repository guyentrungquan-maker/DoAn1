﻿using System;
using System.Collections.Generic;

namespace Flower.Models;

public partial class TbProductCategory
{
    public int CategoryProductld { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public string? Description { get; set; }

    public string? Icon { get; set; }

    public string? Position { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual TbProduct CategoryProductldNavigation { get; set; } = null!;
}
