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
    public class CompanyiesController : ControllerBase
    {
        private readonly Study_EnglishContext _context;

        public CompanyiesController(Study_EnglishContext context)
        {
            _context = context;
        }

        // GET: api/Companyies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Companyy>>> GetCompanyys()
        {
            return await _context.Companyys.ToListAsync();
        }

        // GET: api/Companyies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Companyy>> GetCompanyy(int? id)
        {
            var companyy = await _context.Companyys.FindAsync(id);

            if (companyy == null)
            {
                return NotFound();
            }

            return companyy;
        }

        // PUT: api/Companyies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyy(int? id, Companyy companyy)
        {
            if (id != companyy.IdCompanyy)
            {
                return BadRequest();
            }

            _context.Entry(companyy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyyExists(id))
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

        // POST: api/Companyies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Companyy>> PostCompanyy(Companyy companyy)
        {
            _context.Companyys.Add(companyy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanyy", new { id = companyy.IdCompanyy }, companyy);
        }

        // DELETE: api/Companyies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyy(int? id)
        {
            var companyy = await _context.Companyys.FindAsync(id);
            if (companyy == null)
            {
                return NotFound();
            }

            _context.Companyys.Remove(companyy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyyExists(int? id)
        {
            return _context.Companyys.Any(e => e.IdCompanyy == id);
        }
    }
}
