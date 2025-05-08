using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CampaniasCRUD_NET9.Data;
using Microsoft.Extensions.Configuration;
using System;
using CampaniasCRUD_NET9.Models;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// 1) Registrar MVC
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<InterHubTLocalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("InterHubTLocalContext")));  // NUEVO REGISTRO DEL DBCONTEXT


// 2) Registrar el DbContext con tu cadena de conexión
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                         ?? throw new InvalidOperationException("Cadena de conexión no encontrada")));

// Construir la aplicación
var app = builder.Build();

// Manejo de errores en producción
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Ruta por defecto apunta al controlador Campanias
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Campanias}/{action=Index}/{id?}");

app.Run();
