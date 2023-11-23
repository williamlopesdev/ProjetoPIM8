using System.ComponentModel.DataAnnotations;


namespace marketplace_v4.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Nome { get; set; }
        public long CPF { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        [StringLength(25)]
        public string Senha { get; set; }
        public int Endereco_Id { get; set; }
    }
}
