using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Tipificaciones
{
    public int Id { get; set; }

    public string Tipificacion { get; set; } = null!;

    public int Campania { get; set; }

    public int? Padre { get; set; }

    public bool Habilitado { get; set; }

    public int? CodigoPom { get; set; }
}
