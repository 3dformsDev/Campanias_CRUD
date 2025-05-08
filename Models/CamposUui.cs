using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class CamposUui
{
    public int Id { get; set; }

    public string CampoUui { get; set; } = null!;

    public int Campania { get; set; }

    public int Orden { get; set; }

    public int Longitud { get; set; }

    public int? Habilitado { get; set; }
}
