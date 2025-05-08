using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Roles
{
    public int Id { get; set; }

    public string Rol { get; set; } = null!;

    public bool Habilitado { get; set; }

    public int Tenant { get; set; }
}
