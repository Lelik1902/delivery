using System;
using System.Collections.Generic;

namespace deliveryDomain.Model;

public partial class Courier : Entity
{
    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
