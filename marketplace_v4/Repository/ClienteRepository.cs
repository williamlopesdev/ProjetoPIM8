using EntityFrameworkCore.Repository.Repository;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Repository;
using marketplace_v4.Models;
using Microsoft.EntityFrameworkCore;

namespace marketplace_v4.Repository
{
    public class ClienteRepository : CommonRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(APIDbContext context) : base(context)
        {
        }
    }
}
