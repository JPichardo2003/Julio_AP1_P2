﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Julio_AP1_P2.Server.DAL;
using Julio_AP1_P2.Shared.Models;

namespace Julio_AP1_P2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        private readonly Contexto _context;

        public EntradasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Entradas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entradas>>> GetEntradas()
        {
          if (_context.Entradas == null)
          {
              return NotFound();
          }
            return await _context.Entradas.ToListAsync();
        }

        // GET: api/Entradas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entradas>> GetEntradas(int id)
        {
          if (_context.Entradas == null)
          {
              return NotFound();
          }
            var entradas = await _context.Entradas.FindAsync(id);

            if (entradas == null)
            {
                return NotFound();
            }

            return entradas;
        }

        // PUT: api/Entradas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntradas(int id, Entradas entradas)
        {
            if (id != entradas.EntradaId)
            {
                return BadRequest();
            }

            _context.Entry(entradas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntradasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Entradas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entradas>> PostEntradas(Entradas entradas)
        {
          if (_context.Entradas == null)
          {
              return Problem("Entity set 'Contexto.Entradas'  is null.");
          }
            _context.Entradas.Add(entradas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntradas", new { id = entradas.EntradaId }, entradas);
        }

        // DELETE: api/Entradas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntradas(int id)
        {
            if (_context.Entradas == null)
            {
                return NotFound();
            }
            var entradas = await _context.Entradas.FindAsync(id);
            if (entradas == null)
            {
                return NotFound();
            }

            _context.Entradas.Remove(entradas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Entradas/5
        [HttpDelete("DeleteEntradasMessages/{id}")]
        public async Task<IActionResult> DeleteEntradasMessages(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var entrada = await _context.EntradasDetalle.FirstOrDefaultAsync(ed => ed.DetalleId == id);
            if (entrada is null)
            {
                return NotFound();
            }
            _context.EntradasDetalle.Remove(entrada);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool EntradasExists(int id)
        {
            return (_context.Entradas?.Any(e => e.EntradaId == id)).GetValueOrDefault();
        }
    }
}
