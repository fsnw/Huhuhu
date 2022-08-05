using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Huhuhu.Models;

namespace Huhuhu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostLofesController : ControllerBase
    {
        private readonly HuhuContext _context;

        public PostLofesController(HuhuContext context)
        {
            _context = context;
        }

        // GET: api/PostLofes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostLofe>>> GetPostLoves()
        {
          if (_context.PostLoves == null)
          {
              return NotFound();
          }
            return await _context.PostLoves.ToListAsync();
        }

        // GET: api/PostLofes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostLofe>> GetPostLofe(int id)
        {
          if (_context.PostLoves == null)
          {
              return NotFound();
          }
            var postLofe = await _context.PostLoves.FindAsync(id);

            if (postLofe == null)
            {
                return NotFound();
            }

            return postLofe;
        }

        // PUT: api/PostLofes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostLofe(int id, PostLofe postLofe)
        {
            if (id != postLofe.Id)
            {
                return BadRequest();
            }

            _context.Entry(postLofe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostLofeExists(id))
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

        // POST: api/PostLofes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostLofe>> PostPostLofe(PostLofe postLofe)
        {
          if (_context.PostLoves == null)
          {
              return Problem("Entity set 'HuhuContext.PostLoves'  is null.");
          }
            _context.PostLoves.Add(postLofe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostLofe", new { id = postLofe.Id }, postLofe);
        }

        // DELETE: api/PostLofes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostLofe(int id)
        {
            if (_context.PostLoves == null)
            {
                return NotFound();
            }
            var postLofe = await _context.PostLoves.FindAsync(id);
            if (postLofe == null)
            {
                return NotFound();
            }

            _context.PostLoves.Remove(postLofe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostLofeExists(int id)
        {
            return (_context.PostLoves?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
