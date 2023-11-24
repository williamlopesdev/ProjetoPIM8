using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Manager;
using marketplace_v4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace marketplace_v4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Item_CarrinhoController : ControllerBase
    {
        private readonly APIDbContext _context;
        private IItem_CarrinhoManager _item_CarrinhoManager;


        public Item_CarrinhoController(APIDbContext context)
        {
            _context = context;
            _item_CarrinhoManager = new Item_CarrinhoManager(context);
        }

        // GET: api/ItemCarrinho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item_Carrinho>>> GetItemCarrinho()
        {
            return await _context.Item_Carrinho.ToListAsync();
        }

        // GET: api/ItemCarrinho/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item_Carrinho>> GetItemCarrinho(int id)
        {
            var itemCarrinho = await _context.Item_Carrinho.FindAsync(id);

            if (itemCarrinho == null)
            {
                return NotFound();
            }

            return itemCarrinho;
        }

        // PUT: api/ItemCarrinho/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemCarrinho(int id, Item_Carrinho itemCarrinho)
        {
            if (id != itemCarrinho.Carrinho_Id)
            {
                return BadRequest();
            }

            _context.Entry(itemCarrinho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemCarrinhoExists(id))
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

        // POST: api/ItemCarrinho
        [HttpPost]
        public IActionResult Create(Item_Carrinho item_Carrinho)
        {
            _item_CarrinhoManager.Add(item_Carrinho);
            return CreatedAtAction("GetItem_Carrinho", new { id = item_Carrinho.Carrinho_Id }, item_Carrinho);
        }

        // DELETE: api/ItemCarrinho/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemCarrinho(int id)
        {
            var itemCarrinho = await _context.Item_Carrinho.FindAsync(id);
            if (itemCarrinho == null)
            {
                return NotFound();
            }

            _context.Item_Carrinho.Remove(itemCarrinho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemCarrinhoExists(int id)
        {
            return _context.Item_Carrinho.Any(e => e.Carrinho_Id == id);
        }
    }
}
