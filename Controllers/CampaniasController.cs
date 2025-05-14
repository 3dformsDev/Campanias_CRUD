using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CampaniasCRUD_NET9.Models;

namespace CampaniasCRUD_NET9.Controllers
{
    public class CampaniasController : Controller
    {
        private readonly InterHubTLocalContext _context;

        public CampaniasController(InterHubTLocalContext context)
        {
            _context = context;
        }

        // GET: Campanias
        public async Task<IActionResult> Index(string? busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda))
            {
                var resultado = await _context.Campanias
                    .FirstOrDefaultAsync(c => c.Campania.ToLower() == busqueda.ToLower());

                if (resultado != null)
                {
                    ViewBag.CampaniaEncontradaId = resultado.Id;
                    return View(await _context.Campanias.ToListAsync());
                }
                else
                {
                    ViewBag.NoEncontrado = true;
                }
            }

            return View(await _context.Campanias.ToListAsync());
        }

        


        // GET: Campanias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campanias = await _context.Campanias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campanias == null)
            {
                return NotFound();
            }

            return View(campanias);
        }

        // GET: Campanias/Create

        // GET: Campanias/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Campanias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Campanias campania)
        {
            // Regla 1: Si es tipo Inbound, no debe tener CampaniaPOM ni ListaPOM
            if (campania.Tipo != null && campania.Tipo.ToLower() == "inbound")
            {
                if (!string.IsNullOrWhiteSpace(campania.CampaniaPOM) || !string.IsNullOrWhiteSpace(campania.ListaPOM))
                {
                    ModelState.AddModelError("", "Las campañas de tipo 'Inbound' no deben tener valores en Campaña POM ni Lista POM.");
                }
            }

            // Regla 2: SkillSecundario solo si es tipo Blending
            if (campania.Tipo == null || campania.Tipo.ToLower() != "blending")
            {
                if (!string.IsNullOrWhiteSpace(campania.SkillSecundario))
                {
                    ModelState.AddModelError("", "Solo las campañas del tipo 'Blending' pueden tener Skill Secundario.");
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(campania);
                await _context.SaveChangesAsync();

                // Enviar mensaje de éxito para mostrar pop-up
                TempData["SuccessMessage"] = "¡Campaña creada exitosamente!";
                return RedirectToAction(nameof(Index));
            }

            // Si hay errores, se queda en el formulario de creación
            return View(campania);
        }


        // GET: Campanias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var campania = await _context.Campanias.FindAsync(id);
            if (campania == null) return NotFound();

            return PartialView("Edit", campania); // SIN GUIONES BAJOS NI _EditPartial
        }




        // POST: Campanias/Edit/5


        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Campania,CampaniaPOM,ListaPOM,Tenant,Operacion,Tipo,ANI,DNIS,Skill,VDN,Extension,Agente,UCID,UUI,Guion,Observaciones,Cliente,Tipificacion,CTI,Historico,EtiquetaWFO,CierrePOM,ActualizaPOM,Habilitado,ACWTime,SkillPrincipal,SkillSecundario,TextoGuion,Coleccion,CampoId,CampoTelefono,CampaignPOMID,ContactListID,StrategyID")] Campanias campanias)
        {
            if (id != campanias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campanias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaniasExists(campanias.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(campanias);
        }

        // GET: Campanias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campanias = await _context.Campanias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campanias == null)
            {
                return NotFound();
            }

            return View(campanias);
        }

        // POST: Campanias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campanias = await _context.Campanias.FindAsync(id);
            if (campanias != null)
            {
                _context.Campanias.Remove(campanias);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaniasExists(int id)
        {
            return _context.Campanias.Any(e => e.Id == id);
        }
    }
}
