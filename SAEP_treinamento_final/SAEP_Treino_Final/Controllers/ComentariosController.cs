using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAEP_Treino_Final.Data;
using SAEP_Treino_Final.Models;

namespace SAEP_Treino_Final.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly Contexto _context;

        public ComentariosController(Contexto context)
        {
            _context = context;
        }

        // GET: Comentarios
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Comentarios.Include(c => c.Equipamentos).Include(c => c.Perfis);
            return View(await contexto.ToListAsync());
        }

        // GET: Comentarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentarios = await _context.Comentarios
                .Include(c => c.Equipamentos)
                .Include(c => c.Perfis)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentarios == null)
            {
                return NotFound();
            }

            return View(comentarios);
        }

        // GET: Comentarios/Create
        public IActionResult Create()
        {
            ViewData["IdEquipamento"] = new SelectList(_context.Equipamentos, "Id", "Id");
            ViewData["IdPerfil"] = new SelectList(_context.Perfis, "Id", "Id");
            return View();
        }

        // POST: Comentarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Comentario,IdEquipamento,IdPerfil,Data")] Comentarios comentarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comentarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEquipamento"] = new SelectList(_context.Equipamentos, "Id", "Id", comentarios.IdEquipamento);
            ViewData["IdPerfil"] = new SelectList(_context.Perfis, "Id", "Id", comentarios.IdPerfil);
            return View(comentarios);
        }

        // GET: Comentarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentarios = await _context.Comentarios.FindAsync(id);
            if (comentarios == null)
            {
                return NotFound();
            }
            ViewData["IdEquipamento"] = new SelectList(_context.Equipamentos, "Id", "Id", comentarios.IdEquipamento);
            ViewData["IdPerfil"] = new SelectList(_context.Perfis, "Id", "Id", comentarios.IdPerfil);
            return View(comentarios);
        }

        // POST: Comentarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Comentario,IdEquipamento,IdPerfil,Data")] Comentarios comentarios)
        {
            if (id != comentarios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComentariosExists(comentarios.Id))
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
            ViewData["IdEquipamento"] = new SelectList(_context.Equipamentos, "Id", "Id", comentarios.IdEquipamento);
            ViewData["IdPerfil"] = new SelectList(_context.Perfis, "Id", "Id", comentarios.IdPerfil);
            return View(comentarios);
        }

        // GET: Comentarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentarios = await _context.Comentarios
                .Include(c => c.Equipamentos)
                .Include(c => c.Perfis)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentarios == null)
            {
                return NotFound();
            }

            return View(comentarios);
        }

        // POST: Comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comentarios = await _context.Comentarios.FindAsync(id);
            _context.Comentarios.Remove(comentarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComentariosExists(int id)
        {
            return _context.Comentarios.Any(e => e.Id == id);
        }
    }
}
