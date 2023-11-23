using System.ComponentModel.DataAnnotations;

namespace marketplace_v4.Models
{
    public class Item_Carrinho
    {
        [Key]
        public int Carrinho_Id { get; set; }
        
        public int Produto_Id { get; set; }
        [StringLength(45)]
        public string Quantidade { get; set; }
        public float? Total { get; set; }

    }
}
