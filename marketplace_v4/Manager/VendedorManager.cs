using EntityFrameworkCore.Repository.Manager;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Models;
using marketplace_v4.Repository;

namespace marketplace_v4.Manager
{
    public class VendedorManager : CommonManager<Vendedor>, IVendedorManager
    {
        public VendedorManager(APIDbContext context) : base(new VendedorRepository(context))
        {
        }
    }
}
