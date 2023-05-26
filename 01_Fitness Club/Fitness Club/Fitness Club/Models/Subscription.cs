using System;
using System.Collections.Generic;

namespace Fitness_Club.Models;

public partial class Subscription
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? FreeService { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Service? FreeServiceNavigation { get; set; }
}
