using EntityFrameworkCore.Repository.Manager;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Models;
using marketplace_v4.Repository;

namespace marketplace_v4.Manager
{
    public class EnderecoManager : CommonManager<Endereco>, IEnderecoManager
    {
        public EnderecoManager(APIDbContext context) : base(new EnderecoRepository(context))
        {
        }
    }
}
