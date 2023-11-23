using marketplace_v4.Data;
using marketplace_v4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace marketplace_v4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly APIDbContext _context;

        public VendedorController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Vendedor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendedor>>> GetVendedores()
        {
            return await _context.Vendedor.ToListAsync();
        }

        // GET: api/Vendedor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendedor>> GetVendedor(int id)
        {
            var vendedor = await _context.Vendedor.FindAsync(id);

            if (vendedor == null)
            {
                return NotFound();
            }

            return vendedor;
        }

        // PUT: api/Vendedor/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendedor(int id, Vendedor vendedor)
        {
            if (id != vendedor.Id)
            {
                return BadRequest();
            }

            _context.Entry(vendedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendedorExists(id))
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

        // POST: api/Vendedor
        [HttpPost]
        public async Task<ActionResult<Vendedor>> PostVendedor(Vendedor vendedor)
        {
            _context.Vendedor.Add(vendedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendedor", new { id = vendedor.Id }, vendedor);
        }

        // DELETE: api/Vendedor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendedor(int id)
        {
            var vendedor = await _context.Vendedor.FindAsync(id);
            if (vendedor == null)
            {
                return NotFound();
            }

            _context.Vendedor.Remove(vendedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendedorExists(int id)
        {
            return _context.Vendedor.Any(e => e.Id == id);
        }
    }
}
