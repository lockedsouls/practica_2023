using System;
using System.Collections.Generic;

namespace Fitness_Club.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public decimal? Cash { get; set; }

    public virtual Role? Role { get; set; }
}
