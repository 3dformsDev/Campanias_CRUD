using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Contactos
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Tipo { get; set; } = null!;

    public int Agente { get; set; }

    public string Cliente { get; set; } = null!;

    public int Tipificacion { get; set; }

    public string? Observaciones { get; set; }

    public string? Ucid { get; set; }

    public string? Uui { get; set; }

    public string? Skill { get; set; }

    public string? Telefono { get; set; }
}
