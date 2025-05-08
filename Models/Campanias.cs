using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampaniasCRUD_NET9.Models;

public partial class Campanias
{
    [Key]
    public int Id { get; set; }  // Asegúrate de tener una propiedad como clave primaria



    public string Campania { get; set; } = null!;

    public string? CampaniaPOM { get; set; }
    
    public string? ListaPOM { get; set; }

    public int? Tenant { get; set; }

    public int Operacion { get; set; }

    public string? Tipo { get; set; }

    public bool? ANI { get; set; }

    public bool? DNIS { get; set; }

    public bool? Skill { get; set; }

    public bool? VDN { get; set; }

    public bool? Extension { get; set; }

    public bool? Agente { get; set; }

    public bool? UCID { get; set; }

    public bool? UUI { get; set; }

    public bool? Guion { get; set; }

    public bool? Observaciones { get; set; }

    public bool? Cliente { get; set; }

    public bool? Tipificacion { get; set; }

    public bool? CTI { get; set; }

    public int? Historico { get; set; }

    public bool? EtiquetaWFO { get; set; }

    public bool? CierrePOM { get; set; }

    public bool? ActualizaPOM { get; set; }

    public bool Habilitado { get; set; }

    public int? ACWTime { get; set; }

    public string? SkillPrincipal { get; set; }

    public string? SkillSecundario { get; set; }

    public string? TextoGuion { get; set; }

    public string? Coleccion { get; set; }

    public string? CampoId { get; set; }

    public string? CampoTelefono { get; set; }

    public int? CampaignPOMID { get; set; }

    public int? ContactListID { get; set; }

    public int? StrategyID { get; set; }
}
