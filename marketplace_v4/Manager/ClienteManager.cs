using EntityFrameworkCore.Repository.Interface.Repository;
using EntityFrameworkCore.Repository.Manager;
using EntityFrameworkCore.Repository.Repository;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Models;
using marketplace_v4.Repository;
using Microsoft.EntityFrameworkCore;

namespace marketplace_v4.Manager
{
    public class ClienteManager : CommonManager<Cliente>, IClienteManager
    {
        public ClienteManager(APIDbContext context) : base(new ClienteRepository(context))
        {
        }
    }
}
