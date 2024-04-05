using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudEng.Models;

namespace StudEng.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModullesController : ControllerBase
    {
        private readonly Study_EnglishContext _context;

        public ModullesController(Study_EnglishContext context)
        {
            _context = context;
        }

        // GET: api/Modulles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modulle>>> GetModulles()
        {
            return await _context.Modulles.ToListAsync();
        }

        // GET: api/Modulles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Modulle>> GetModulle(int? id)
        {
            var modulle = await _context.Modulles.FindAsync(id);

            if (modulle == null)
            {
                return NotFound();
            }

            return modulle;
        }

        // PUT: api/Modulles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModulle(int? id, Modulle modulle)
        {
            if (id != modulle.IdModulle)
            {
                return BadRequest();
            }

            _context.Entry(modulle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModulleExists(id))
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

        // POST: api/Modulles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Modulle>> PostModulle(Modulle modulle)
        {
            _context.Modulles.Add(modulle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModulle", new { id = modulle.IdModulle }, modulle);
        }

        // DELETE: api/Modulles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModulle(int? id)
        {
            var modulle = await _context.Modulles.FindAsync(id);
            if (modulle == null)
            {
                return NotFound();
            }

            _context.Modulles.Remove(modulle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModulleExists(int? id)
        {
            return _context.Modulles.Any(e => e.IdModulle == id);
        }
    }
}
