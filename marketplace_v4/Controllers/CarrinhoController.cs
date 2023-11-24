using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Manager;
using marketplace_v4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace marketplace_v4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    private class CarrinhoController : ControllerBase
    {
        private readonly APIDbContext _context;
        private ICarrinhoManager _carrinhoManager;


        private CarrinhoController(APIDbContext context)
        {
            _context = context;
            _carrinhoManager = new CarrinhoManager(context);

        }

        // GET: api/Carrinho
        [HttpGet]
        private async Task<ActionResult<IEnumerable<Carrinho>>> GetCarrinho()
        {
            return await _context.Carrinho.Include(c => c.Cliente).Include(c => c.Produtos).ToListAsync();
        }

        // GET: api/Carrinho/5
        [HttpGet("{id}")]
        private async Task<ActionResult<Carrinho>> GetCarrinho(int id)
        {
            var carrinho = await _context.Carrinho
                .Include(c => c.Cliente)
                .Include(c => c.Produtos)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (carrinho == null)
            {
                return NotFound();
            }

            return carrinho;
        }

        // PUT: api/Carrinho/5
        [HttpPut("{id}")]
        private async Task<IActionResult> PutCarrinho(int id, Carrinho carrinho)
        {
            if (id != carrinho.Id)
            {
                return BadRequest();
            }

            _context.Entry(carrinho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrinhoExists(id))
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

        // POST: api/Carrinho
        [HttpPost]
        private IActionResult Create(Carrinho carrinho)
        {
            _carrinhoManager.Add(carrinho);
            return CreatedAtAction("GetCarrinho", new { id = carrinho.Id }, carrinho);
        }

        // DELETE: api/Carrinho/5
        [HttpDelete("{id}")]
        private async Task<IActionResult> DeleteCarrinho(int id)
        {
            var carrinho = await _context.Carrinho.FindAsync(id);
            if (carrinho == null)
            {
                return NotFound();
            }

            _context.Carrinho.Remove(carrinho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarrinhoExists(int id)
        {
            return _context.Carrinho.Any(e => e.Id == id);
        }
    }
}

