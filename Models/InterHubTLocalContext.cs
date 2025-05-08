using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CampaniasCRUD_NET9.Models;

public partial class InterHubTLocalContext : DbContext
{
    public InterHubTLocalContext()
    {
    }

    public InterHubTLocalContext(DbContextOptions<InterHubTLocalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Campanias> Campanias { get; set; }

    public virtual DbSet<Campos> Campos { get; set; }

    public virtual DbSet<CamposUui> CamposUuis { get; set; }

    public virtual DbSet<Conexiones> Conexiones { get; set; }

    public virtual DbSet<Contactos> Contactos { get; set; }

    public virtual DbSet<DtvCarga> DtvCargas { get; set; }

    public virtual DbSet<DtvCustom> DtvCustoms { get; set; }    

    public virtual DbSet<Modulos> Modulos { get; set; }

    public virtual DbSet<ModulosRol> ModulosRols { get; set; }

    public virtual DbSet<Operaciones> Operaciones { get; set; }

    public virtual DbSet<Reportes> Reportes { get; set; }

    public virtual DbSet<ReportesUsuario> ReportesUsuarios { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<RolesUsuario> RolesUsuarios { get; set; }

    public virtual DbSet<Tenants> Tenants { get; set; }

    public virtual DbSet<Tipificaciones> Tipificaciones { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=InterHub_T_Local;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Campanias>(entity =>
        {
            entity.HasKey(e => e.Id); // AQUI VA LA CLAVE PRINCIPAL

            entity.Property(e => e.ActualizaPOM).HasColumnName("ActualizaPOM");
            entity.Property(e => e.ACWTime).HasColumnName("ACWTime");
            entity.Property(e => e.ANI).HasColumnName("ANI");
            entity.Property(e => e.CampaignPOMID).HasColumnName("CampaignPOMID");
            entity.Property(e => e.Campania)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Campania");
            entity.Property(e => e.CampaniaPOM)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CampaniaPOM");
            entity.Property(e => e.CampoId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CampoTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CierrePOM).HasColumnName("CierrePOM");
            entity.Property(e => e.Coleccion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContactListID).HasColumnName("ContactListID");
            entity.Property(e => e.CTI).HasColumnName("CTI");
            entity.Property(e => e.DNIS).HasColumnName("DNIS");
            entity.Property(e => e.EtiquetaWFO).HasColumnName("EtiquetaWFO");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ListaPOM)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ListaPOM");
            entity.Property(e => e.SkillPrincipal)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.SkillSecundario)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyID).HasColumnName("StrategyID");
            entity.Property(e => e.TextoGuion).IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UCID).HasColumnName("UCID");
            entity.Property(e => e.UUI).HasColumnName("UUI");
            entity.Property(e => e.VDN).HasColumnName("VDN");
        });

        modelBuilder.Entity<Campos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Campos__3213E83FFB23F435");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Campania).HasColumnName("campania");
            entity.Property(e => e.Campo1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.Editable).HasColumnName("editable");
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.Longitud).HasColumnName("longitud");
            entity.Property(e => e.Obligatorio).HasColumnName("obligatorio");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Visible).HasColumnName("visible");
        });

        modelBuilder.Entity<CamposUui>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CamposUU__3213E83F84057ADD");

            entity.ToTable("CamposUUI");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Campania).HasColumnName("campania");
            entity.Property(e => e.CampoUui)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("campoUUI");
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.Longitud).HasColumnName("longitud");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<Conexiones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conexion__3213E83F260FD422");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Basedatos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("basedatos");
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Conexion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conexion");
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.Servidor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("servidor");
            entity.Property(e => e.Tipobasedatos)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipobasedatos");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Contactos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contacto__3213E83F09F2335D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cliente)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Skill)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ucid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("UCID");
            entity.Property(e => e.Uui)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("UUI");
        });

        modelBuilder.Entity<DtvCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DTV_Carga");

            entity.Property(e => e.AccountIp)
                .HasMaxLength(25)
                .HasColumnName("ACCOUNT_IP");
            entity.Property(e => e.Base)
                .HasMaxLength(30)
                .HasColumnName("BASE");
            entity.Property(e => e.Campana)
                .HasMaxLength(30)
                .HasColumnName("CAMPANA");
            entity.Property(e => e.Cedula)
                .HasMaxLength(65)
                .HasColumnName("CEDULA");
            entity.Property(e => e.CicloBase)
                .HasMaxLength(40)
                .HasColumnName("CICLO_BASE");
            entity.Property(e => e.CicloName)
                .HasMaxLength(22)
                .HasColumnName("CICLO_NAME");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(15)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(10)
                .HasColumnName("FECHA_FIN_");
            entity.Property(e => e.FechaInic)
                .HasMaxLength(10)
                .HasColumnName("FECHA_INIC");
            entity.Property(e => e.IdCampana)
                .HasMaxLength(70)
                .HasColumnName("ID_CAMPANA");
            entity.Property(e => e.MesCampan)
                .HasMaxLength(10)
                .HasColumnName("MES_CAMPAN");
            entity.Property(e => e.MopAdultos)
                .HasMaxLength(80)
                .HasColumnName("MOP_ADULTOS");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(60)
                .HasColumnName("NOMBRE_COMPLETO");
            entity.Property(e => e.Paar)
                .HasMaxLength(4)
                .HasColumnName("PAAR");
            entity.Property(e => e.Premium1)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_1");
            entity.Property(e => e.Premium10)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_10");
            entity.Property(e => e.Premium2)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_2");
            entity.Property(e => e.Premium3)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_3");
            entity.Property(e => e.Premium4)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_4");
            entity.Property(e => e.Premium9)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_9");
            entity.Property(e => e.Producto)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Provincia)
                .HasMaxLength(20)
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Pu)
                .HasMaxLength(3)
                .HasColumnName("PU");
            entity.Property(e => e.TMeZone)
                .HasMaxLength(11)
                .HasColumnName("T_ME_ZONE");
            entity.Property(e => e.TTalDecos)
                .HasMaxLength(16)
                .HasColumnName("T_TAL_DECOS");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_1");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_2");
            entity.Property(e => e.Telefono3)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_3");
            entity.Property(e => e.Telefono4)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_4");
            entity.Property(e => e.Telefono5)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_5");
            entity.Property(e => e.Telefono6)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_6");
            entity.Property(e => e.Telefono7)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_7");
            entity.Property(e => e.Telefono8)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_8");
            entity.Property(e => e.ValorFactura)
                .HasMaxLength(50)
                .HasColumnName("VALOR_FACTURA");
            entity.Property(e => e.ZonaInstalCion)
                .HasMaxLength(111)
                .HasColumnName("ZONA_INSTAL_CION");
        });

        modelBuilder.Entity<DtvCustom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DTV_Custom");

            entity.Property(e => e.AccountIp)
                .HasMaxLength(25)
                .HasColumnName("ACCOUNT_IP");
            entity.Property(e => e.Base)
                .HasMaxLength(30)
                .HasColumnName("BASE");
            entity.Property(e => e.Campana)
                .HasMaxLength(30)
                .HasColumnName("CAMPANA");
            entity.Property(e => e.Cedula)
                .HasMaxLength(65)
                .HasColumnName("CEDULA");
            entity.Property(e => e.CicloBase)
                .HasMaxLength(40)
                .HasColumnName("CICLO_BASE");
            entity.Property(e => e.CicloName)
                .HasMaxLength(4000)
                .HasColumnName("CICLO_NAME");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(15)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(10)
                .HasColumnName("FECHA_FIN_");
            entity.Property(e => e.FechaInic)
                .HasMaxLength(10)
                .HasColumnName("FECHA_INIC");
            entity.Property(e => e.IdCampana)
                .HasMaxLength(70)
                .HasColumnName("ID_CAMPANA");
            entity.Property(e => e.MesCampan)
                .HasMaxLength(10)
                .HasColumnName("MES_CAMPAN");
            entity.Property(e => e.MopAdultos)
                .HasMaxLength(80)
                .HasColumnName("MOP_ADULTOS");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(60)
                .HasColumnName("NOMBRE_COMPLETO");
            entity.Property(e => e.Paar)
                .HasMaxLength(4)
                .HasColumnName("PAAR");
            entity.Property(e => e.Premium1)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_1");
            entity.Property(e => e.Premium10)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_10");
            entity.Property(e => e.Premium2)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_2");
            entity.Property(e => e.Premium3)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_3");
            entity.Property(e => e.Premium4)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_4");
            entity.Property(e => e.Premium9)
                .HasMaxLength(20)
                .HasColumnName("PREMIUM_9");
            entity.Property(e => e.Producto)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Provincia)
                .HasMaxLength(20)
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Pu)
                .HasMaxLength(3)
                .HasColumnName("PU");
            entity.Property(e => e.TMeZone)
                .HasMaxLength(11)
                .HasColumnName("T_ME_ZONE");
            entity.Property(e => e.TTalDecos)
                .HasMaxLength(16)
                .HasColumnName("T_TAL_DECOS");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_1");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_2");
            entity.Property(e => e.Telefono3)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_3");
            entity.Property(e => e.Telefono4)
                .HasMaxLength(20)
                .HasColumnName("TELEFONO_4");
            entity.Property(e => e.Telefono5)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_5");
            entity.Property(e => e.Telefono6)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_6");
            entity.Property(e => e.Telefono7)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_7");
            entity.Property(e => e.Telefono8)
                .HasMaxLength(12)
                .HasColumnName("TELEFONO_8");
            entity.Property(e => e.ValorFactura)
                .HasMaxLength(50)
                .HasColumnName("VALOR_FACTURA");
            entity.Property(e => e.ZonaInstalCion)
                .HasMaxLength(111)
                .HasColumnName("ZONA_INSTAL_CION");
        });

        modelBuilder.Entity<Modulos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Metodo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("metodo");
            entity.Property(e => e.Modulo1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Modulo");
            entity.Property(e => e.Ruta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ruta");
        });

        modelBuilder.Entity<ModulosRol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ModulosRol");
        });

        modelBuilder.Entity<Operaciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CampoId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CampoTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Coleccion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Imagen)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reportes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reportes__3213E83F22D46510");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conexion).HasColumnName("conexion");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("fechafin");
            entity.Property(e => e.Fechainicio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("fechainicio");
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.Operacion).HasColumnName("operacion");
            entity.Property(e => e.Reporte1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reporte");
            entity.Property(e => e.Sentencia)
                .IsUnicode(false)
                .HasColumnName("sentencia");
        });

        modelBuilder.Entity<ReportesUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportesUsuario");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rol)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RolesUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RolesUsuario");
        });

        modelBuilder.Entity<Tenants>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Imagen)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Tenant1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tenant");
        });

        modelBuilder.Entity<Tipificaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipifica__3214EC07515B41F8");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoPom).HasColumnName("CodigoPOM");
            entity.Property(e => e.Tipificacion).IsUnicode(false);
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UltimoLogin).HasColumnType("datetime");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
