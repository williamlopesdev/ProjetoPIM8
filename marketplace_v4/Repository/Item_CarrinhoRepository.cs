using EntityFrameworkCore.Repository.Repository;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Repository;
using marketplace_v4.Models;

namespace marketplace_v4.Repository
{
    public class Item_CarrinhoRepository : CommonRepository<Item_Carrinho>, IItem_CarrinhoRepository
    {
        public Item_CarrinhoRepository(APIDbContext context) : base(context)
        {
        }
    }
}
