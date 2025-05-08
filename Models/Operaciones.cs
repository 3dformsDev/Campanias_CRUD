using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Operaciones
{
    public int Id { get; set; }

    public string Operacion { get; set; } = null!;

    public int Tenant { get; set; }

    public string? Coleccion { get; set; }

    public string? CampoId { get; set; }

    public string? CampoTelefono { get; set; }

    public string? Imagen { get; set; }

    public bool Habilitado { get; set; }
}
