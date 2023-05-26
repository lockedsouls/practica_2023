using System;
using System.Collections.Generic;

namespace Fitness_Club.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? Subscription { get; set; }

    public decimal? Cash { get; set; }

    public virtual Subscription? SubscriptionNavigation { get; set; }
}
