using EntityFrameworkCore.Repository.Repository;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Repository;
using marketplace_v4.Models;

namespace marketplace_v4.Repository
{
    public class EnderecoRepository : CommonRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(APIDbContext context) : base(context)
        {
        }
    }
}
