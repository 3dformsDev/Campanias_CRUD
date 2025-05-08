using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Usuarios
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int Tenant { get; set; }

    public int? Operacion { get; set; }

    public bool Habilitado { get; set; }

    public DateTime? UltimoLogin { get; set; }
}
