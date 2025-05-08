using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Conexiones
{
    public int Id { get; set; }

    public string Conexion { get; set; } = null!;

    public string Servidor { get; set; } = null!;

    public string Basedatos { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public bool Habilitado { get; set; }

    public string? Tipobasedatos { get; set; }
}
