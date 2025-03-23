using System;
using System.Collections.Generic;

namespace deliveryDomain.Model;

public partial class Payment : Entity
{
    public int OrderId { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
