using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChallengeSprint2.Models;

namespace ChallengeSprint2.Controllers
{
    public class AvaliacoesController : Controller
    {
        private readonly Contexto _context;

        public AvaliacoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Avaliacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Avaliacoes.ToListAsync());
        }

        // GET: Avaliacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacoes = await _context.Avaliacoes
                .FirstOrDefaultAsync(m => m.IdAvaliacoes == id);
            if (avaliacoes == null)
            {
                return NotFound();
            }

            return View(avaliacoes);
        }

        // GET: Avaliacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Avaliacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAvaliacoes,Comentario,NotaAvaliacao,DataAvaliacao,StatusAvaliacao")] Avaliacoes avaliacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avaliacoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(avaliacoes);
        }

        // GET: Avaliacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacoes = await _context.Avaliacoes.FindAsync(id);
            if (avaliacoes == null)
            {
                return NotFound();
            }
            return View(avaliacoes);
        }

        // POST: Avaliacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAvaliacoes,Comentario,NotaAvaliacao,DataAvaliacao,StatusAvaliacao")] Avaliacoes avaliacoes)
        {
            if (id != avaliacoes.IdAvaliacoes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avaliacoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvaliacoesExists(avaliacoes.IdAvaliacoes))
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
            return View(avaliacoes);
        }

        // GET: Avaliacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacoes = await _context.Avaliacoes
                .FirstOrDefaultAsync(m => m.IdAvaliacoes == id);
            if (avaliacoes == null)
            {
                return NotFound();
            }

            return View(avaliacoes);
        }

        // POST: Avaliacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avaliacoes = await _context.Avaliacoes.FindAsync(id);
            if (avaliacoes != null)
            {
                _context.Avaliacoes.Remove(avaliacoes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvaliacoesExists(int id)
        {
            return _context.Avaliacoes.Any(e => e.IdAvaliacoes == id);
        }
    }
}
