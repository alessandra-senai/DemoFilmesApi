using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoFilmesApi.Context;
using DemoFilmesApi.Models;

namespace DemoFilmesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeDiretoresController : ControllerBase
    {
        private readonly FilmesContext _context;

        public FilmeDiretoresController(FilmesContext context)
        {
            _context = context;
        }

        // GET: api/FilmeDiretores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmeDiretor>>> GetFilmeDiretores()
        {
            return await _context.FilmeDiretores.ToListAsync();
        }

        // GET: api/FilmeDiretores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmeDiretor>> GetFilmeDiretor(int id)
        {
            var filmeDiretor = await _context.FilmeDiretores.FindAsync(id);

            if (filmeDiretor == null)
            {
                return NotFound();
            }

            return filmeDiretor;
        }

        // PUT: api/FilmeDiretores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmeDiretor(int id, FilmeDiretor filmeDiretor)
        {
            if (id != filmeDiretor.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmeDiretor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeDiretorExists(id))
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

        // POST: api/FilmeDiretores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmeDiretor>> PostFilmeDiretor(FilmeDiretor filmeDiretor)
        {
            _context.FilmeDiretores.Add(filmeDiretor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmeDiretor", new { id = filmeDiretor.Id }, filmeDiretor);
        }

        // DELETE: api/FilmeDiretores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmeDiretor(int id)
        {
            var filmeDiretor = await _context.FilmeDiretores.FindAsync(id);
            if (filmeDiretor == null)
            {
                return NotFound();
            }

            _context.FilmeDiretores.Remove(filmeDiretor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmeDiretorExists(int id)
        {
            return _context.FilmeDiretores.Any(e => e.Id == id);
        }
    }
}
