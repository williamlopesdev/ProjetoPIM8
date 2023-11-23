using System.ComponentModel.DataAnnotations;

namespace marketplace_v4.Models
{
    public class Carrinho
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
