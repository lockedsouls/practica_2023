using System;
using System.Collections.Generic;

namespace Fitness_Club.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Role1 { get; set; }

    public decimal? Salary { get; set; }

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
