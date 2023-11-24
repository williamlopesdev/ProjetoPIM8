using EntityFrameworkCore.Repository.Manager;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Manager;
using marketplace_v4.Models;
using marketplace_v4.Repository;

namespace marketplace_v4.Manager
{
    public class Item_CarrinhoManager : CommonManager<Item_Carrinho>, IItem_CarrinhoManager
    {
        public Item_CarrinhoManager(APIDbContext context) : base(new Item_CarrinhoRepository(context))
        {
        }
    }
}
