using System;
using System.Collections.Generic;

namespace deliveryDomain.Model;

public partial class Good : Entity
{
    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
