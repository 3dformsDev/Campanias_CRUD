using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Tenants
{
    public int Id { get; set; }

    public string Tenant1 { get; set; } = null!;

    public string? Imagen { get; set; }

    public bool Habilitado { get; set; }
}
