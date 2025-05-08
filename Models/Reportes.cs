using System;
using System.Collections.Generic;

namespace CampaniasCRUD_NET9.Models;

public partial class Reportes
{
    public int Id { get; set; }

    public int Operacion { get; set; }

    public string Reporte1 { get; set; } = null!;

    public string Sentencia { get; set; } = null!;

    public string Fechainicio { get; set; } = null!;

    public string Fechafin { get; set; } = null!;

    public int Conexion { get; set; }

    public bool Habilitado { get; set; }
}
