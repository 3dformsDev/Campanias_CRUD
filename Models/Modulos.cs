using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Modulos
{
    public int Id { get; set; }

    public string Modulo1 { get; set; } = null!;

    public bool Habilitado { get; set; }

    public string? Ruta { get; set; }

    public string? Metodo { get; set; }
}
