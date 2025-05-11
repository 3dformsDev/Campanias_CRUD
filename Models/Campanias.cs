using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampaniasCRUD_NET9.Models;

public partial class Campanias
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(100), Display(Name = "Campaña")]
    public string Campania { get; set; } = null!;

    [StringLength(100), Display(Name = "Campaña POM")]
    public string? CampaniaPOM { get; set; }

    [StringLength(100), Display(Name = "Lista POM")]
    public string? ListaPOM { get; set; }

    [Display(Name = "Tenant")]
    public int? Tenant { get; set; }

    [Required, Display(Name = "Operación")]
    public int Operacion { get; set; }

    [StringLength(10), Display(Name = "Tipo")]
    public string? Tipo { get; set; }

    [Display(Name = "ANI")]
    public bool? ANI { get; set; }

    [Display(Name = "DNIS")]
    public bool? DNIS { get; set; }

    [Display(Name = "Skill")]
    public bool? Skill { get; set; }

    [Display(Name = "VDN")]
    public bool? VDN { get; set; }

    [Display(Name = "Extensión")]
    public bool? Extension { get; set; }

    [Display(Name = "Agente")]
    public bool? Agente { get; set; }

    [Display(Name = "UCID")]
    public bool? UCID { get; set; }

    [Display(Name = "UUI")]
    public bool? UUI { get; set; }

    [Display(Name = "Guión")]
    public bool? Guion { get; set; }

    [Display(Name = "Observaciones")]
    public bool? Observaciones { get; set; }

    [Display(Name = "Cliente")]
    public bool? Cliente { get; set; }

    [Display(Name = "Tipificación")]
    public bool? Tipificacion { get; set; }

    [Display(Name = "CTI")]
    public bool? CTI { get; set; }

    [Display(Name = "Histórico")]
    public int? Historico { get; set; }

    [Display(Name = "Etiqueta WFO")]
    public bool? EtiquetaWFO { get; set; }

    [Display(Name = "Cierre POM")]
    public bool? CierrePOM { get; set; }

    [Display(Name = "Actualiza POM")]
    public bool? ActualizaPOM { get; set; }

    [Required, Display(Name = "Habilitado")]
    public bool Habilitado { get; set; }

    [Display(Name = "ACW Time")]
    public int? ACWTime { get; set; }

    [StringLength(60), Display(Name = "Skill Principal")]
    public string? SkillPrincipal { get; set; }

    [StringLength(20), Display(Name = "Skill Secundario")]
    public string? SkillSecundario { get; set; }

    [Display(Name = "Texto Guión")]
    public string? TextoGuion { get; set; }

    [StringLength(20), Display(Name = "Colección")]
    public string? Coleccion { get; set; }

    [StringLength(50), Display(Name = "Campo ID")]
    public string? CampoId { get; set; }

    [StringLength(50), Display(Name = "Campo Teléfono")]
    public string? CampoTelefono { get; set; }

    [Display(Name = "Campaign POM ID")]
    public int? CampaignPOMID { get; set; }

    [Display(Name = "Contact List ID")]
    public int? ContactListID { get; set; }

    [Display(Name = "Strategy ID")]
    public int? StrategyID { get; set; }
}
