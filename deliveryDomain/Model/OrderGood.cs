using System;
using System.Collections.Generic;

namespace deliveryDomain.Model;

public partial class OrderGood : Entity
{
    public int Quantity { get; set; }

    public virtual Order Id1 { get; set; } = null!;

    public virtual Good IdNavigation { get; set; } = null!;
}
