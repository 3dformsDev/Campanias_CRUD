using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Campos
{
    public int Id { get; set; }

    public int Campania { get; set; }

    public string Campo1 { get; set; } = null!;

    public int? Orden { get; set; }

    public string Tipo { get; set; } = null!;

    public int Longitud { get; set; }

    public bool? Obligatorio { get; set; }

    public bool? Editable { get; set; }

    public bool? Visible { get; set; }

    public bool? Habilitado { get; set; }
}
