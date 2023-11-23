using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using marketplace_v4.Models;

namespace marketplace_v4.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Item_Carrinho> Item_Carrinho { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }

}
