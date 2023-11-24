using EntityFrameworkCore.Repository.Interface.Repository;
using EntityFrameworkCore.Repository.Manager;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Models;
using marketplace_v4.Repository;

namespace marketplace_v4.Manager
{
    public class CarrinhoManager : CommonManager<Carrinho>, ICarrinhoManager
    {
        public CarrinhoManager(APIDbContext context) : base(new CarrinhoRepository(context))
        {
        }
    }
}
