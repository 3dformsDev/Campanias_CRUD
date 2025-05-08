using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CampaniasCRUD_NET9.Data;
using CampaniasCRUD_NET9.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CampaniasCRUD_NET9.Controllers
{
    public class CampaniasController_backup : Controller
    {
        private readonly AppDbContext _context;

        public CampaniasController_backup(AppDbContext context)
        {
            _context = context;
        }

        // Index con funcionalidad de búsqueda
        public async Task<IActionResult> Index(string? busqueda)
        {
            var campanias = from c in _context.Campanias
                            select c;

            if (!string.IsNullOrEmpty(busqueda))
            {
                campanias = campanias.Where(c => c.Campania.Contains(busqueda));
            }

            var lista = await campanias.ToListAsync();
            return View(lista);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Campanias camp)
        {
            if (!ModelState.IsValid) return View(camp);
            if (camp.Tipo?.ToLower() == "inbound") { camp.ListaPOM = null; camp.CampaniaPOM = null; }
            if (camp.Tipo?.ToLower() != "blending") camp.SkillSecundario = null;
            _context.Add(camp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var camp = await _context.Campanias.FindAsync(id);
            if (camp == null) return NotFound();
            return View(camp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Campanias camp)
        {
            if (id != camp.Id) return NotFound();
            if (!ModelState.IsValid) return View(camp);
            if (camp.Tipo?.ToLower() == "inbound") { camp.ListaPOM = null; camp.CampaniaPOM = null; }
            if (camp.Tipo?.ToLower() != "blending") camp.SkillSecundario = null;
            _context.Update(camp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var camp = await _context.Campanias.FindAsync(id);
            if (camp == null) return NotFound();
            return View(camp);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var camp = await _context.Campanias.FindAsync(id);
            if (camp != null)
            {
                _context.Campanias.Remove(camp);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var camp = await _context.Campanias.FindAsync(id);
            if (camp == null) return NotFound();
            return View(camp);
        }
    }
}
