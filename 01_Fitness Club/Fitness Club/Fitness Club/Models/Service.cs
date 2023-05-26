using System;
using System.Collections.Generic;

namespace Fitness_Club.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
