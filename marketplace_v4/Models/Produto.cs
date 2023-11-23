using System.ComponentModel.DataAnnotations;

namespace marketplace_v4.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [StringLength(45)]
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        [StringLength(200)]
        public string Imagem { get; set; }
        public string Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
