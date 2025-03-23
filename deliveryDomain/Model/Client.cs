using System;
using System.Collections.Generic;

namespace deliveryDomain.Model;

public partial class Client : Entity
{
    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual Order? Order { get; set; }
}
