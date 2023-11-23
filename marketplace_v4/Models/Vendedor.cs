using System.ComponentModel.DataAnnotations;

namespace marketplace_v4.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string RazaoSocial { get; set; }
        [StringLength(70)]
        public string NomeFantasia { get; set; }
        [StringLength(18)]
        public string CNPJ { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        public decimal Comissao { get; set; }
        public Endereco Endereco { get; set; }
    }
}
